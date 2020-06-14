using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mascota
    {
        public int CodigoMascota { get; set; }
        public string NombreMascota { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Raza laRaza { get; set; }
        public Color UnColor { get; set; }
        public Cliente Dueño { get; set; }        

        public Mascota(int codigoMascota, string nombreMascota, DateTime fechaNacimiento, Raza laRaza, Color unColor, Cliente dueño)
        {
            CodigoMascota = codigoMascota;
            NombreMascota = nombreMascota;
            this.fechaNacimiento = fechaNacimiento;
            this.laRaza = laRaza;
            UnColor = unColor;
            Dueño = dueño;
            
        }

        public Mascota()
        {
            this.laRaza = new Raza();
            this.Dueño = new Cliente();
        }
    }
}
