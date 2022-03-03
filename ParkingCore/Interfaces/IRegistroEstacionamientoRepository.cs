using ParkingCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingCore.Interfaces
{
    public interface IRegistroEstacionamientoRepository
    {
        Task<RegistroEstacionamiento> GetRegistroByCLientID(int id);
        Task<IEnumerable<RegistroEstacionamiento>> GetRegistros();
        Task InsertarRegistro(RegistroEstacionamiento clt);
    }
}