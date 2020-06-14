using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     public class Persona
    {
        public int Cedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Persona(int cedula, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, string correo)
        {
            Cedula = cedula;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Telefono = telefono;
            Correo = correo;
        }

        public Persona()
        {

        }

        public string NombreCompleto()
        {
            return this.PrimerNombre + " " + this.SegundoNombre + " " + this.PrimerApellido + " " + this.SegundoApellido;
        }
    }
}
