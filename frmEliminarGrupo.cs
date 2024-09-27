using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Agenda_Contactos
{
    public partial class frmEliminarGrupo : Form
    {
        Dictionary<string, List<Contacto>> lista {  get; set; }
        public frmEliminarGrupo()
        {
            InitializeComponent();
            ValoresPorDefault();
        }

        public void ValoresPorDefault()
        {
            diseño();
            CargarContactos();
        }
        private void diseño()
        {
            Color colorFondo = ColorTranslator.FromHtml("#244E60");
            Color colorTextBox = ColorTranslator.FromHtml("#F5E6CA");
            Color colorContenedores = ColorTranslator.FromHtml("#F0F0F0");
            Color blanco = ColorTranslator.FromHtml("#FFF");

            this.BackColor = colorFondo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            gbEliminarGrupo.BackColor = colorFondo;
            gbEliminarGrupo.ForeColor = blanco;

            btnAceptar.BackColor = blanco;
            btnAceptar.ForeColor = Color.Black;

            cmbGrupos.BackColor = colorContenedores;
            cmbGrupos.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void CargarContactos()
        {
            ConexionBD db = new ConexionBD();
            lista = db.AgruparContactos();
            cargarCMB();
        }
        private void cargarCMB()
        {
            cmbGrupos.Items.Clear();
            foreach(var item in lista)
            {
                cmbGrupos.Items.Add(item.Key);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string grupoEliminar = cmbGrupos.Text;
            if(grupoEliminar != null)
            {
                DialogResult res = MessageBox.Show("¿Desea eliminar los contactos registrados en este grupo? \n" +
                    "->YES: para aceptar. \n->NO: para asignarlos al grupo Varios. \n->CANCEL: para cancelar."
                    ,"IMPORTANTE",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

                if(res == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Contactos WHERE grupo = '{grupoEliminar}'";
                    ConexionBD db = new ConexionBD();
                    int filasAfectadas = db.EliminarGrupoYContactos(query);
                    string mensaje = $"Se eliminó a {filasAfectadas} contacto/s";
                    MessageBox.Show(mensaje,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    CargarContactos();
                }
                else if(res == DialogResult.No)  
                {
                    string query = $"UPDATE Contactos SET grupo = 'Varios' WHERE grupo = '{grupoEliminar}'";
                    ConexionBD db = new ConexionBD();
                    int filasAfectadas = db.EliminarGrupoYContactos(query);
                    string mensaje = $"Se modificó el grupo a {filasAfectadas} contacto/s";
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarContactos();
                }
                else
                {
                    MessageBox.Show("Procedimiento cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }
    }
}
