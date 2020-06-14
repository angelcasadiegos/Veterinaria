using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistorialRegistro
    {
        private int CodigoHistorialRegistros{ get; set; }
        public RegistroServicio UnRegistro { get; set; }

        public HistorialRegistro()
        {

        }
        public HistorialRegistro(RegistroServicio unRegistro)
        {
            UnRegistro = unRegistro;
        }
    }

    


}
