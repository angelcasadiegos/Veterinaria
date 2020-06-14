using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cargo
    {
        public int CodigoCargo { get; set; }
        public string NombreCargo { get; set; }

        public Cargo(string nombreCargo)
        {
            NombreCargo = nombreCargo;
        }

        public Cargo()
        {

        }
    }
}
