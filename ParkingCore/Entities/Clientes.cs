using System;
using System.Collections.Generic;

namespace ParkingCore.Entities
{
    public partial class Clientes
    {
        private readonly double costoHora = 10;
        public int IdCliente { get; set; }
        public string Placa { get; set; }
        public TimeSpan HoraAcceso { get; set; }
        public DateTime FechaAcceso { get; set; }
        public int TipCliente { get; set; }

        public TipoClientes TipoCliente { get; set; }
        public virtual RegistroPension RegistroPension { get; set; }

        public double GetCobroEstacionamiento(double cantidadHrs)
        {
            float descuento = 0.9f;
            double costo = costoHora * cantidadHrs;
            double Total = costo - (costo * descuento);

            return Total;
        }
    }
}
