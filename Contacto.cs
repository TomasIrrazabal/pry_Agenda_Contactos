using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry_Agenda_Contactos
{
    internal class Contacto
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string grupo { get; set; }
        public string correo { get; set; }
        public string numero { get; set; }
        
        public Contacto(int id, string nombre, string grupo, string correo, string numero)
        {
            this.id = id;
            this.nombre = nombre;
            this.grupo = grupo;
            this.correo = correo;
            this.numero = numero;
        }
    }
}
