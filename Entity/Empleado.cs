using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado:Persona
    {
        public Cargo UnCargo;
        public DateTime fechaIngreso;

        public Empleado(Cargo unCargo, DateTime fechaIngreso, int cedula, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, string correo)
            : base(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, correo)
        {
            UnCargo = unCargo;
            this.fechaIngreso = fechaIngreso;
        }

        public Empleado()
        {

        }
    }
}
