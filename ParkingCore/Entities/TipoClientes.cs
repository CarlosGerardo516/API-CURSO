using System;
using System.Collections.Generic;

namespace ParkingCore.Entities
{
    public partial class TipoClientes
    {
        public TipoClientes()
        {
            Cliente = new HashSet<Clientes>();
        }

        public int ID { get; set; }
        public string Nombre { get; set; }

        public ICollection<Clientes> Cliente { get; set; }
    }
}
