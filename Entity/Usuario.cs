using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario : Persona
    {
        private string UserName { get; set; }
        private string Pass { get; set; }
        private string Tipo { get; set; }

        public Usuario(string cedula, string nombre, string apellido, string edad, string sexo, string telefono, string correo, string username, string pass,string tipo):base(cedula, nombre, apellido, edad, sexo, telefono, correo)
        {
            UserName = username;
            Pass = pass;
            Tipo = tipo;
        }
        
        
    }

    


}
