using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     public abstract class Persona
    {       
        private string Cedula { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Edad { get; set; }
        private string Sexo { get; set; }
        private string Telefono { get; set; }
        private string Correo { get; set; }

        

        public Persona(string cedula, string nombre, string apellido, string edad, string sexo, string telefono, string correo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Sexo = sexo;
            Telefono = telefono;
            Correo = correo;            

        }        

    }
}
