using Microsoft.EntityFrameworkCore;
using ParkingCore.Entities;
using ParkingCore.Interfaces;
using ParkingInfrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingInfrastructure.Repositories
{
    public class TipoClienteRepository : ITipoClienteRepository
    {
        private readonly ESTACIONAMIENTOContext _context;

        public TipoClienteRepository(ESTACIONAMIENTOContext parkingContext)
        {
            _context = parkingContext;
        }

        public async Task<IEnumerable<TipoClientes>> GetTiposCliente()
        {
            var Tipos = await _context.TiposCliente.ToListAsync();
            return Tipos;
        }
        public async Task<TipoClientes> GetTipoByID(int id)
        {
            var tipo = await _context.TiposCliente.FirstOrDefaultAsync(x => x.ID == id);

            return tipo;
        }
        public async Task InsertClient(TipoClientes clt)
        {
            _context.Add(clt);
            await _context.SaveChangesAsync();
        }
    }
}
