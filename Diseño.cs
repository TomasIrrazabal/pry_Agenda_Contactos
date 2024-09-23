using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Agenda_Contactos
{
    internal class Diseño
    {
        public void ColoresDefault(frmInicio form)
        {
            form.BackColor = ColorTranslator.FromHtml("#A7C7E7");

            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    control.BackColor = ColorTranslator.FromHtml("#F5E6CA");
                }
                if(control is TreeView || control is Panel)
                {
                    control.BackColor = ColorTranslator.FromHtml("#F0F0F0");
                }
            }
        }
    }
}
