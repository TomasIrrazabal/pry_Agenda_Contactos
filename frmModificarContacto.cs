using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace pry_Agenda_Contactos
{
    public partial class frmModificarContacto : Form
    {
        public Contacto contactoRecibido { get; set; }
        public Contacto devolverContacto { get; set; }
        public Dictionary<string,List<Contacto>> lista {  get; set; }
        public frmModificarContacto(Contacto contacto, Dictionary<string, List<Contacto>> lista)
        {
            InitializeComponent();
            diseño();
            this.contactoRecibido = contacto;
            CargarContacto();
            this.lista = lista;
        }
        public void diseño()
        {
            Color colorFondo = ColorTranslator.FromHtml("#244E60");
            Color colorTextBox = ColorTranslator.FromHtml("#F5E6CA");
            Color colorContenedores = ColorTranslator.FromHtml("#F0F0F0");
            Color blanco = ColorTranslator.FromHtml("#FFF");

            this.BackColor = colorFondo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) control.BackColor = colorTextBox;

                if (control is TreeView || control is Panel) control.BackColor = colorContenedores;

                if (control is GroupBox)
                {
                    control.ForeColor = blanco;
                    control.BackColor = colorFondo;
                    foreach (Control c in control.Controls)
                    {
                        c.ForeColor = blanco;
                        if (c is TextBox) c.ForeColor = Color.Black;
                    }
                }
                if (control is Button) control.BackColor = colorContenedores;

                if (control is Label) control.ForeColor = blanco;
            }
        }
        private void CargarContacto()
        {
            if (contactoRecibido != null)
            {
                txtNombre.Text = contactoRecibido.nombre;
                txtGrupo.Text = contactoRecibido.grupo;
                txtCorreo.Text = contactoRecibido.correo;
                txtNumero.Text = contactoRecibido.numero.ToString();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = prepararString(txtNombre.Text);
            string grupo = prepararString(txtGrupo.Text);
            if (!string.IsNullOrEmpty(nombre))
            {
                ConexionBD db = new ConexionBD();
                if (db.ValidarExistenciaDelContacto(nombre))
                {
                    if (grupo != string.Empty && !lista.ContainsKey(grupo))
                    {
                        DialogResult res = MessageBox.Show("El grupo ingresado " + '"' + $"*{grupo}" + '"' +
                            " se creara como un nuevo grupo. \n¿Está de acuerdo? ", "Aviso ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (res == DialogResult.OK)
                        {
                            EmpaquetarContacto(grupo);
                        }
                        else
                        {
                            MessageBox.Show("Revise el campo de " + '"' + "Grupo" + '"' + "por favor.", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (grupo == string.Empty)
                    {

                        DialogResult res = MessageBox.Show("El campo " + '"' + "Grupo" + '"' + "no fue rellenado " +
                            "\n¿Desea asignar el nuevo contacto al grupo " + "'" + "*Varios?" + "'", "Aviso Importante",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (res == DialogResult.OK)
                        {
                            EmpaquetarContacto("Varios");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Revise el campo de " + '"' + "Grupo" + '"' + "por favor.", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (grupo != string.Empty && lista.ContainsKey(grupo))
                    {
                        EmpaquetarContacto(grupo);
                    }
                }
                else
                {
                    MessageBox.Show("El nombre: " + '"' + $"{prepararString(txtNombre.Text)}" + '"' + " ya está ingresado.", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Revise el campo de " + '"' + "*Nombre" + '"' + "por favor. \nEste campo es obligatorio.", "", MessageBoxButtons.OK);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string prepararString(string str)
        {
            TextInfo textInfo = new CultureInfo("es-ES", false).TextInfo;
            str = str.ToLower().Trim();
            str = textInfo.ToTitleCase(str);
            return str;
        }
        private void EmpaquetarContacto(string grupo)
        {
            ConexionBD db = new ConexionBD();
            long nuevoID = db.BuscarNuevoID();
            long numero;
            string numeroTexto = prepararString(txtNumero.Text.Replace(" ", ""));
            if (long.TryParse(numeroTexto, out numero)) ;
            devolverContacto = new Contacto()
            {
                id = nuevoID + 1,
                nombre = prepararString(txtNombre.Text),
                grupo = grupo,
                correo = prepararString(txtCorreo.Text),
                numero = numero,
            };
            this.Close();
        }
    }
}
