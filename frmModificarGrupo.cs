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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pry_Agenda_Contactos
{
    public partial class frmModificarGrupo : Form
    {
        Dictionary<string,List<Contacto>> list {  get; set; }
        List<string> grupos = new List<string>();
        public string grupo { get; set; }
        public string grupoSeleccionado { get; set; }
        public frmModificarGrupo( Dictionary<string, List<Contacto>> list)
        {
            InitializeComponent();
            this.list = list;
            valoresPorDefault();
        }
        private void valoresPorDefault()
        {
            diseño(this);
            listarGrupos();
            cargarCMB();
        }

        public void diseño(frmModificarGrupo form)
        {
            Color colorFondo = ColorTranslator.FromHtml("#244E60");
            Color colorTextBox = ColorTranslator.FromHtml("#F5E6CA");
            Color colorContenedores = ColorTranslator.FromHtml("#F0F0F0");
            Color blanco = ColorTranslator.FromHtml("#FFF");

            form.BackColor = colorFondo;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            lblSeleccion.ForeColor = blanco;
            lblGrupo.ForeColor = blanco;
            txtGrupo.ForeColor = Color.Black;
            txtGrupo.BackColor = blanco;    
            btnAceptar.BackColor = blanco;
            btnAceptar.ForeColor = Color.Black;
            btnCancelar.BackColor = blanco;
            btnCancelar.ForeColor = Color.Black;
            btnReiniciar.BackColor = blanco;
            btnReiniciar.ForeColor = Color.Black;
            gbGrupos.ForeColor = blanco;
            cmbGrupos.BackColor = colorContenedores;
            cmbGrupos.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void listarGrupos()
        {
            foreach(var item in list)
            {
                string grupo = item.Key;
                grupos.Add(grupo);
            }
        }
        private void cargarCMB()
        {
            cmbGrupos.Items.Clear();
            foreach(var item in grupos)
            {
                cmbGrupos.Items.Add(item);
            }
        }
        private void cmbGrupos_DropDown(object sender, EventArgs e)
        {
            if(cmbGrupos.Text == "Seleccione una opción...")
            {
                cmbGrupos.Text = string.Empty;
            }
        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrupos.SelectedIndex == -1)
            {
                cmbGrupos.Text = "Seleccione una opción...";
            }
            else
            {
                txtGrupo.Text = cmbGrupos.Text;
                grupoSeleccionado = cmbGrupos.Text;
            }
        }

        //fixme
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string grupoAux = prepararString(txtGrupo.Text);
            if(grupoAux != string.Empty)
            {
                if(grupoSeleccionado != grupoAux)
                {
                    if (!list.ContainsKey(grupoAux))
                    {
                        DialogResult res = MessageBox.Show("¿Desea aplicar los cambios?", "Aviso ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if(res == DialogResult.OK)
                        {
                            grupo = grupoAux;
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se detecto ningún cambio.", "Aviso ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                }
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

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrupo.Text))
            {
                cmbGrupos.Enabled = true;
            }
            else if (txtGrupo.Text == grupoSeleccionado)
            {
                cmbGrupos.Enabled = true;
            }
            else
            {
                cmbGrupos.Enabled = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            cmbGrupos.SelectedIndex = 0;
            cmbGrupos.Enabled = true;
            txtGrupo.Text = string.Empty;
        }
    }
}
