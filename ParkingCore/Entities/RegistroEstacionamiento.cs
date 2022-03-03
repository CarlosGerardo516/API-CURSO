using System;
using System.Collections.Generic;

namespace ParkingCore.Entities
{
    public partial class RegistroEstacionamiento
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public double TotalCobro { get; set; }
        public TimeSpan HoraAcceso { get; set; }
        public DateTime FechaAcceso { get; set; }
        public TimeSpan? HoraSalida { get; set; }
        public DateTime? FechaSalida { get; set; }
    }
}
