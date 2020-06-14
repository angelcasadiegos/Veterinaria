using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TipoMascota
    {
        public int CodigoTipoMascota { get; set; }
        public string NombreTipoMascota { get; set; }

        public TipoMascota()
        {

        }
        public TipoMascota(int codigoTipoMascota, string nombreTipoMascota)
        {
            CodigoTipoMascota = codigoTipoMascota;
            NombreTipoMascota = nombreTipoMascota;
        }
    }
}
