using ParkingCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingCore.Interfaces
{
    public interface ITipoClienteRepository
    {
        Task<TipoClientes> GetTipoByID(int id);
        Task<IEnumerable<TipoClientes>> GetTiposCliente();
        Task InsertClient(TipoClientes clt);
    }
}