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
    public partial class frmEliminarContacto : Form
    {
        Dictionary<string, List<Contacto>> lista { get; set; }
        public string contactoSeleccionado { get; set; }
        public frmEliminarContacto(Dictionary<string, List<Contacto>> lista)
        {
            this.lista = lista;
            InitializeComponent();
            ValoresPorDefecto();
        }
        private void ValoresPorDefecto()
        {
            diseño();
            cargarCMB();
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
            gbEliminarContacto.BackColor = colorFondo;
            gbEliminarContacto.ForeColor = blanco;
            btnAceptar.BackColor = blanco;
            btnAceptar.ForeColor = Color.Black;            
            cmbContactos.BackColor = colorContenedores;
            
            cmbContactos.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void cargarCMB()
        {
            cmbContactos.Items.Clear();
            foreach(var categoria in lista)
            {
                foreach(Contacto contacto in categoria.Value)
                {
                    cmbContactos.Items.Add(contacto.nombre);
                }
            }
            cmbContactos.SelectedIndex = 0;
        }
        private void CargarContactos()
        {

            ConexionBD db = new ConexionBD();
            lista = db.AgruparContactos();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (contactoSeleccionado != null)
            {
                DialogResult res = MessageBox.Show($"¿Está seguro de eliminar a {contactoSeleccionado}?", 
                    "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if(res == DialogResult.OK)
                {
                    MessageBox.Show($"¡Se eliminara permanentemente a: {contactoSeleccionado}!",
                        "",MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
                    ConexionBD db = new ConexionBD();
                    string query = $"DELETE FROM Contactos WHERE nombre = '{contactoSeleccionado}'";
                    db.EliminarContacto(query);
                    CargarContactos();
                    cargarCMB();
                }
            }
        }

        private void cmbContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbContactos.SelectedIndex != -1 && cmbContactos.Text != string.Empty)
            {
                contactoSeleccionado = cmbContactos.Text;

            }
        }
    }
}
