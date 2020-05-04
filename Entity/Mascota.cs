using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mascota
    {
        private int IdentificadorMascota { get; set; }
        private Persona CedulaTercero{get;set;}
        private string Nombre { get; set; }
        private Color Color { get; set; }
        private Raza Raza { get; set; }
        private string Edad { get; set; }
        private string Sexo { get; set; }
        private float Peso { get; set; }
        private Especie Especie { get; set; }

        public Mascota()
        {

        }

        public Mascota(Persona cedulaTercero, string nombre, Color color, Raza raza, string edad, string sexo, float peso, Especie especie)
        {
            CedulaTercero = cedulaTercero;
            Nombre = nombre;
            Color = color;
            Raza = raza;
            Edad = edad;
            Sexo = sexo;
            Peso = peso;
            Especie = especie;
        }
        
        public void MuestraMascota()
        {
            Console.Write($"Datos de Mascota: {CedulaTercero};{Nombre};{Color};{Raza};{Edad};{Sexo};{Peso};{Especie};");
        }
    }
}
