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
        public string Tipo { get; set; }   
        public string Sexo { get; set; }
        public string Tamaño { get; set; }
        public float PorcentajeTarifa { get; set; }

        public TipoMascota(int codigoTipoMascota, string tipo, string sexo, string tamaño, float porcentajeTarifa)
        {
            CodigoTipoMascota = codigoTipoMascota;
            Tipo = tipo;
            Sexo = sexo;
            Tamaño = tamaño;
            PorcentajeTarifa = porcentajeTarifa;
        }

        public TipoMascota()
        {

        }    

    }
}
