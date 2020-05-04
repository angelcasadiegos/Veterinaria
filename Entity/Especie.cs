using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Especie
    {
        private int CodigoEspecie { get; set; }
        private string NombreEspecie { get; set; }

        public Especie()
        {

        }
        public Especie(int codigoEspecie, string nombreEspecie)
        {
            CodigoEspecie = codigoEspecie;
            NombreEspecie = nombreEspecie;
        }
    }
}
