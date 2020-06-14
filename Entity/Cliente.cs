using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente : Persona
    {
        public DateTime FechaRegistro { get; set; }        
        public IList<Mascota> Mascotas { get; set; }

        public Cliente()
        {

        }

        public Cliente(DateTime fechaRegistro, IList<Mascota> mascotas, int cedula, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, string correo)
            :base(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, correo)
        {
            FechaRegistro = fechaRegistro;
            Mascotas = mascotas;
        }
    }
}
