using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Cita
    {
        private int CodigodeCita { get; set; }
        private int IdentificadorMascota { get; set; }
        private string CedulaVeterinario { get; set; }
        private int IdentificadorServicio { get; set;}
        private DateTime FechaCita { get; set; }
        private string EstadoCita { get; set; }
        private DateTime FechadeRegistro { get; set; }
        private DateTime HoraCita { get; set; }

        public Cita()
        {
                
        }
        public Cita(int codigodeCita, int identificadorMascota, string cedulaVeterinario, int identificadorServicio, DateTime fechaCita, string estadoCita, DateTime fechadeRegistro, DateTime horacita)
        {
            CodigodeCita = codigodeCita;
            IdentificadorMascota = identificadorMascota;
            CedulaVeterinario = cedulaVeterinario;
            IdentificadorServicio = identificadorServicio;
            FechaCita = fechaCita;
            EstadoCita = estadoCita;
            FechadeRegistro = fechadeRegistro;
            HoraCita = horacita;
        }


    }
}
