using Microsoft.EntityFrameworkCore;
using ParkingCore.Entities;
using ParkingCore.Interfaces;
using ParkingInfrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingInfrastructure.Repositories
{
    public class RegistroEstacionamientoRepository : IRegistroEstacionamientoRepository
    {
        private readonly ESTACIONAMIENTOContext _context;
        public RegistroEstacionamientoRepository(ESTACIONAMIENTOContext contexto)
        {
            _context = contexto;
        }
        public async Task<IEnumerable<RegistroEstacionamiento>> GetRegistros()
        {
            var clientes = await _context.Registros.ToListAsync();
            return clientes;
        }
        public async Task<RegistroEstacionamiento> GetRegistroByCLientID(int id)
        {
            var clientes = await _context.Registros.FirstOrDefaultAsync(x => x.ClienteID == id);
            return clientes;
        }
        public async Task InsertarRegistro(RegistroEstacionamiento clt)
        {
            _context.Add(clt);
            await _context.SaveChangesAsync();
        }
    }
}
