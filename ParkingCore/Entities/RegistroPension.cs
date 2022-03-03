using System;
using System.Collections.Generic;

namespace ParkingCore.Entities
{
    public partial class RegistroPension
    {
        public int RegistroID { get; set; }
        public int ClienteID { get; set; }
        public DateTime FechaInicio { get; set; }

        public Clientes Cliente { get; set; }
    }
}
