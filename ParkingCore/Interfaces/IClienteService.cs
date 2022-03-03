using ParkingCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingCore.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<Clientes>> GetClientes();

        Task<Clientes> GetClientByID(int id);

        Task InsertClient(Clientes clt);

        Task<bool> updateCliente(Clientes clt);

        Task<bool> DeleteCliente(int id);

        Task<Clientes> GetCobroTotal(Clientes cliente);
    }
}