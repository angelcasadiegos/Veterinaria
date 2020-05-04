using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class CategoriadeServicio
    {
        private int CodigoCaregoriaServicio { get; set; }
        private string CategoriaServicio { get; set; }
        private string NombreCategoria { get; set; }

        public CategoriadeServicio()
        {

        }

        public CategoriadeServicio(int codigocategoriaservicio, string nombrecategoria)
        {
            this.CodigoCaregoriaServicio = codigocategoriaservicio;
            this.NombreCategoria = nombrecategoria;
        }

       
    }
}
