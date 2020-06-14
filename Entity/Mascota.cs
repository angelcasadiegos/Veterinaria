﻿using System;
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
        public DateTime FechaNacimiento { get; set; }
        public Raza laRaza { get; set; }
        public Color UnColor { get; set; }
        public Cliente Cedula { get; set; }  
        public int Edad { get; set; }
        public int Sexo { get; set; }

        public Mascota(int codigoMascota, string nombreMascota, DateTime fechaNacimiento, Raza laRaza, Color unColor, Cliente cedula, int edad, int sexo)
        {
            CodigoMascota = codigoMascota;
            NombreMascota = nombreMascota;
            FechaNacimiento = fechaNacimiento;
            this.laRaza = laRaza;
            UnColor = unColor;
            Cedula = cedula;
            Edad = edad;
            Sexo = sexo;
        }

        public Mascota()
        {
            this.laRaza = new Raza();
            this.Cedula = new Cliente();
        }
    }
}
