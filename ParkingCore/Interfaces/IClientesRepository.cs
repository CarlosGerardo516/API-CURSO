using ParkingCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCore.Interfaces
{
    public interface IClientesRepository
    {
        Task<IEnumerable<Clientes>> GetClientes();

        Task<Clientes> GetClientByID(int id);

        Task InsertClient(Clientes clt);

        Task<bool> updateCliente(Clientes clt);

        Task<bool> DeleteCliente(int id);
    }
}
