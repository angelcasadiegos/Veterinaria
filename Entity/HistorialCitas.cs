using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistorialCitas
    {
        private int CodigoHistorialCitas { get; set; }
        private int IdentificadorCita { get; set; }

        public HistorialCitas()
        {

        }
        public HistorialCitas(int codigoHistorialCitas, int identificadorCita)
        {
            CodigoHistorialCitas = codigoHistorialCitas;
            IdentificadorCita = identificadorCita;
        }
    }

    


}
