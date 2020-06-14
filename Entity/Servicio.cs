using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public int CodigodeServicio { get; set; }
        public string NombreServicio { get; set; }
        public double ValorServicio { get; set; }        
        public Servicio()
        {

        }
        public Servicio(int codigodeServicio, string nombreServicio, decimal valorServicio)
        {
            CodigodeServicio = codigodeServicio;
            NombreServicio = nombreServicio;
            ValorServicio = valorServicio;
        }
    }
}
