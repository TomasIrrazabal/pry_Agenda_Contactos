using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Agenda_Contactos
{
    public class ConexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;

        string cadenaConexion;
        public ConexionBD()
        {
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./../../DB/Contactos.accdb";
        }
        public Dictionary<string,List<Contacto>> AgruparContactos()
        {
            Dictionary<string,List<Contacto>> lista = new Dictionary<string,List<Contacto>>();
            
            try
            {
                using(conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Contactos";
                    using(comando = new OleDbCommand(query, conexion))
                    {
                        using(OleDbDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                
                                //fixme
                                Contacto contactoAux = new Contacto()
                                {
                                    id  = lector.GetInt64(0),
                                    nombre = lector.GetString(1),
                                    grupo  = lector.GetString(2),
                                    correo = lector.GetString(3),
                                    numero = lector.GetInt64(4)
                                };
                                if (!lista.ContainsKey(contactoAux.grupo))
                                {
                                    lista[contactoAux.grupo] = new List<Contacto>();    
                                }
                                lista[contactoAux.grupo].Add(contactoAux);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error en listar Contactos \n {ex.Message}","Error",MessageBoxButtons.OK);
            }
            return lista;
        }
        public long BuscarNuevoID()
        {

            long nuevoId = 0;
            try
            {
                using (conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT MAX(ID) AS UltimoID FROM Contactos;";
                    using (comando = new OleDbCommand(query, conexion))
                    {
                        object res = comando.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            nuevoId = (long)res;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en busqueda de nuevo ID\n"+ex.Message,"Error",MessageBoxButtons.OK);
            }
             return nuevoId;
        }
        public bool ValidarExistenciaDelContacto(string nombre)
        {
            bool res = true;
            try
            {
                using (conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = $"SELECT * FROM Contactos WHERE nombre = '{nombre}'";
                    using (comando = new OleDbCommand(query, conexion))
                    {
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            res = false;
                            MessageBox.Show("El contacto que desea ingresar ya está registrado", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validacion de contacto existente\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return res;
        }
        public string AgregarNuevoContacto(Contacto contacto)
        {
            string mensaje = string.Empty;
            try
            {
                if(contacto!= null)
                {
                    if (ValidarExistenciaDelContacto(contacto.nombre))
                    {
                        using (conexion = new OleDbConnection(cadenaConexion))
                        {
                            conexion.Open();
                            string query = $"INSERT INTO Contactos (ID, Nombre, Grupo, Correo, Numero) VALUES ({contacto.id},'{contacto.nombre}'" +
                                $",'{contacto.grupo}','{contacto.correo}',{contacto.numero})";
                            using (comando = new OleDbCommand(query, conexion))
                            {
                                int filasAfectadas = comando.ExecuteNonQuery();
                                mensaje = filasAfectadas > 0 ? "Se agrego correctamente el nuevo usuario " :
                                    "El usuario ya existe, se canceló el procedimiento";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en registro de nuevo contacto\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return mensaje;
        }
        public string ModificarContacto(string query)
        {
            string mensaje = "No se aplicaron los cambios";
            try
            {
                using(conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    using(comando = new OleDbCommand(query, conexion))
                    {
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if(filasAfectadas > 0)
                        {
                            mensaje = "El contacto ha sido actualizado correctamente.";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en actualizar contacto:\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return mensaje;
        }
        public string ModificarGrupo(string query)
        {
            string mensaje = "No se aplicaron los cambios";
            using (conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();
                using(comando = new OleDbCommand(query, conexion))
                {
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if( filasAfectadas > 0)
                    {
                        mensaje = $"Se completo la operación.\n El número de Contactos modificados fue: {filasAfectadas}";
                    }
                }
            }

            return mensaje;
        }
        public void EliminarContacto(string query)
        {
            try
            {
                using (conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    using(comando = new OleDbCommand(query, conexion))
                    {
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if(filasAfectadas == 0)
                        {
                            throw new Exception("No se pudo eliminar el contacto)");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error en eliminar contacto: {ex.Message}");
            }
        }
        public int EliminarGrupoYContactos(string query)
        {
            int filasAfectadas = 0;
            try
            {
                using (conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();
                    using(comando = new OleDbCommand(query, conexion))
                    {
                        filasAfectadas = comando.ExecuteNonQuery();
                        if( filasAfectadas > 0)
                        {
                            return filasAfectadas;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en eliminar Grupo: {ex.Message}");
            }
            return filasAfectadas;
        }
    }
}
