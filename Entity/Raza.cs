using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Raza
    {
        private int CodigoRaza { get; set; }
        private string NombreRaza { get; set; }

        public Raza()
        {

        }
        public Raza(int codigoRaza, string nombreRaza)
        {
            CodigoRaza = codigoRaza;
            NombreRaza = nombreRaza;
        }

        
    }
}
