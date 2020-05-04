using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Cliente : Persona
    {
        private Mascota Mascota;

        public Cliente(string cedula, string nombre, string apellido, string edad, string sexo, string telefono, string correo, Mascota mascota):base(cedula, nombre, apellido, edad, sexo, telefono, correo)
        {
            Mascota = mascota;
        }


    }
}
