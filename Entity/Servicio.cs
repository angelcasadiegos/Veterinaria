using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Servicio
    {
        private int CodigodeServicio { get; set; }
        private string NombreServicio { get; set; }
        private decimal Valor { get; set; }

        public CategoriadeServicio categoria;

        public Servicio()
        {

        }

        public Servicio(int codigoservicio, string nombreservicio, decimal valor)
        { 
            CodigodeServicio = codigoservicio;
            NombreServicio = nombreservicio;
            Valor = valor;
            
        }

        
    }
}
