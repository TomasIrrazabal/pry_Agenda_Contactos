using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace pry_Agenda_Contactos
{
    public partial class frmInicio : Form
    {
        ConexionBD db;
        Contacto contactoActual = null;
        Dictionary<string, List<Contacto>> grupoDeContactos = new Dictionary<string, List<Contacto>>();
        public frmInicio()
        {
            InitializeComponent();
            ValoresPorDefecto();
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
            tvContactos.BackColor = colorContenedores;
            gbInfoContacto.BackColor = colorFondo;
            gbInfoContacto.ForeColor = blanco;

            lblNombre.ForeColor = blanco;
            txtNombre.BackColor = colorContenedores;
            lblGrupo.ForeColor = blanco;
            txtGrupo.BackColor = colorContenedores;
            lblCorreo.ForeColor = blanco;
            txtCorreo.BackColor = colorContenedores;
            lblNumero.ForeColor = blanco;
            txtNumero.BackColor = colorContenedores;

            gbInfoContacto.Refresh();
        }
        public void ValoresPorDefecto()
        {
            LimpiarComponentes();
            CargarTreeView();
            diseño();
        }
        private void LimpiarComponentes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                    c.Text = string.Empty;
                }
                if(c is GroupBox)
                {
                    c.Visible = false;
                    foreach(Control control in c.Controls)
                    {
                        c.Enabled = false;
                    }
                }
            }
            tvContactos.Nodes.Clear();
        }
        private void CargarTreeView()
        {
            tvContactos.Nodes.Clear();
            CargarContactos();

            foreach (var grupo in grupoDeContactos)
            {
                TreeNode grupoNodo = new TreeNode(grupo.Key);

                foreach(var contacto in grupo.Value)
                {
                    string contactoTexto = $"{contacto.nombre}"; 
                    TreeNode nodoContacto = new TreeNode(contactoTexto);
                    grupoNodo.Nodes.Add(nodoContacto);
                }
                tvContactos.Nodes.Add((TreeNode)grupoNodo);
            }
        }
        private void CargarContactos()
        {
            db = new ConexionBD();
            grupoDeContactos = db.AgruparContactos();
        }
        private Contacto BuscarContacto(string nombre)
        {
            Contacto contacto = null;
            foreach(var grupo in grupoDeContactos)
            {
                foreach(var c in grupo.Value)
                {
                    if (c.nombre.Equals(nombre))
                    {
                        contacto = c;
                    }
                }
            }
            return contacto;   
        }
        
        private void tvContactos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Contacto contacto = null;
            if(e.Node.Parent != null)
            {
                string nombreContacto = e.Node.Text;
                contacto = BuscarContacto (nombreContacto);
                if(contacto != null)
                {   
                    gbInfoContacto.Visible = true;
                    txtNombre.Text = contacto.nombre;
                    txtGrupo.Text = contacto.grupo;
                    txtCorreo.Text = contacto.correo;
                    txtNumero.Text = contacto.numero.ToString();
                    contactoActual = contacto;
                }
            }
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarNuevoContacto frm = new frmCargarNuevoContacto(grupoDeContactos);
            frm.ShowDialog();
            Contacto contactoAux = frm.contacto;
            if(contactoAux != null)
            {
                ConexionBD db = new ConexionBD();
                string mensaje = db.AgregarNuevoContacto(contactoAux);
                MessageBox.Show(mensaje,"Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CargarTreeView();
        }

        private void modificarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactoActual != null)
            {
                frmModificarContacto frm = new frmModificarContacto(contactoActual,grupoDeContactos);
                frm.ShowDialog();
                Contacto contactoAux = frm.devolverContacto;
                if (contactoAux != null)
                {
                    ConexionBD bd = new ConexionBD();
                    string query = $"UPDATE Contactos SET Nombre = '{contactoAux.nombre}', Grupo = '{contactoAux.grupo}'," +
                        $" Correo = '{contactoAux.correo}', Numero = {contactoAux.numero} WHERE ID = {contactoActual.id};";
                    db.ModificarContacto(query);
                }
                LimpiarComponentes();
                CargarTreeView();
            }
            else
            {
                MessageBox.Show("Seleccione en el árbol el contacto ha modificar","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modificarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarGrupo frm = new frmModificarGrupo(grupoDeContactos);
            frm.ShowDialog();
            string nuevoGrupo = frm.grupo;
            string grupoSeleccionado = frm.grupoSeleccionado;
            if(!string.IsNullOrEmpty(nuevoGrupo))
            {
                string query = $"UPDATE Contactos SET grupo = '{nuevoGrupo}' WHERE grupo = '{grupoSeleccionado}'";
                ConexionBD db = new ConexionBD();   
                string mensaje = db.ModificarGrupo(query);
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarComponentes();
            CargarTreeView();
        }

        private void eliminarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarContacto frm = new frmEliminarContacto(grupoDeContactos);
            frm.ShowDialog();
            LimpiarComponentes();
            CargarTreeView();
        }

        private void eliminarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarGrupo frm = new frmEliminarGrupo();
            frm.ShowDialog();
            LimpiarComponentes();
            CargarTreeView();
        }
    }
}
