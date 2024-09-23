using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./../../BASE_DATOS/Contactos.accdb";
        }
    }
}
