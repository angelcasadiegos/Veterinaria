using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Raza
    {
        public int CodigoRaza { get; set; }
        public TipoMascota tipoMascota { get; set; }
        public string laRaza { get; set; }

        public Raza(TipoMascota tipoMascota, string laRaza)
        {
            this.tipoMascota = tipoMascota;
            this.laRaza = laRaza;
        }

        public Raza()
        {
            this.tipoMascota = new TipoMascota();
        }
        

        
    }
}
