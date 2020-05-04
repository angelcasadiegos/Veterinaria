using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Color
    {
        private int CodigoColor { get; set; }
        private string NombreColor { get; set; }

        public Color()
        {

        }

        public Color(int codigoColor, string nombreColor)
        {
            CodigoColor = codigoColor;
            NombreColor = nombreColor;
        }

        

    }
}
