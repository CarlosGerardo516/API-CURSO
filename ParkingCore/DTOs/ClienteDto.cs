using ParkingCore.Entities;
using System;

namespace ParkingCore.DTOs
{
    public class ClienteDto
    {
        public int IdCliente { get; set; }
        public string Placa { get; set; }
        public TimeSpan HoraAcceso { get; set; }
        public DateTime FechaAcceso { get; set; }
        public int TipCliente { get; set; }
        public TipoClienteDto TipoCliente { get; set; }
    }
}
