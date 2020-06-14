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
        public IList<Servicio> Servicios { get; set; }  
        public int NServicios { get { return this.Servicios.Count; } }
        public double SubTotal { get { return this.Servicios.Sum(x => x.ValorServicio); } }
        public double Total { get { return this.SubTotal; } }

        public RegistroServicio()
        {
            Servicios = new List<Servicio>();
        }

        public RegistroServicio(Cliente unCliente, Empleado unVeterinario, IList<Servicio> servicios)
        {
            UnCliente = unCliente;
            UnVeterinario = unVeterinario;
            Servicios = servicios;
        }

        public override string ToString()
        {
            return $"Cliente: {UnCliente.NombreCompleto()}\nEmpleado: {UnVeterinario.NombreCompleto()}\nServicios: {NServicios}\nSubTotal: {SubTotal}\nTotal: {Total}";
        }
    }
}