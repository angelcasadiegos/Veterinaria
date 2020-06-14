using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegistroServicio
    {
        public int CodigoRegistro { get; set; }
        public Cliente UnCliente { get; set; }
        public Mascota UnaMascota { get; set; }
        public Empleado UnVeterinario { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }        
        public string diagnostico { get; set;}
        public Servicio Servicio { get; set; }    
        public decimal Valortotal { get; set; }

        public RegistroServicio(int codigoRegistro, Cliente unCliente, Mascota unaMascota, Empleado unVeterinario, DateTime fecha, DateTime hora, string diagnostico, Servicio servicio, decimal valortotal)
        {
            CodigoRegistro = codigoRegistro;
            UnCliente = unCliente;
            UnaMascota = unaMascota;
            UnVeterinario = unVeterinario;
            Fecha = fecha;
            Hora = hora;
            this.diagnostico = diagnostico;
            Servicio = servicio;
            Valortotal = valortotal;
        }

        public RegistroServicio()
        {
            this.UnaMascota = new Mascota();
            this.UnCliente = new Cliente();
            this.UnVeterinario = new Empleado();
        }

        public decimal CalculoValorServicio(Servicio ValorServicio, Mascota PorcentajeTarifa )
        {
            Valortotal = Servicio.ValorServicio * Convert.ToDecimal(UnaMascota.laRaza.tipoMascota.PorcentajeTarifa);

            return Valortotal;
        }



        
    }
}
