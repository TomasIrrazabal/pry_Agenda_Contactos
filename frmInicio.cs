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
    public partial class frmInicio : Form
    {
        Diseño diseño = new Diseño();
        
        public frmInicio()
        {
            InitializeComponent();
            diseño.ColoresDefault(this);
            valoresPorDefecto();
        }
        public void valoresPorDefecto()
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Enabled = false;
                }
            }
        }
        
    }
}
