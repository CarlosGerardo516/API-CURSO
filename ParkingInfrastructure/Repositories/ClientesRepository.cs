using Microsoft.EntityFrameworkCore;
using ParkingCore.Entities;
using ParkingCore.Interfaces;
using ParkingInfrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCore.Repositories
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly ESTACIONAMIENTOContext _context;
        public ClientesRepository(ESTACIONAMIENTOContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Clientes>> GetClientes()
        {
            var clientes = await _context.Clients.ToListAsync();
            return clientes;
        }
        public async Task<Clientes> GetClientByID(int id)
        {
            var clientes = await _context.Clients.FirstOrDefaultAsync(x => x.IdCliente == id);
            return clientes;
        }
        public async Task InsertClient(Clientes clt)
        {
            _context.Add(clt);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> updateCliente(Clientes clt)
        {
            var currClient = await GetClientByID(clt.IdCliente);
            currClient.Placa = clt.Placa;
            currClient.TipCliente = clt.TipCliente;

            int rowsAffected = await _context.SaveChangesAsync();
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteCliente(int id)
        {
            var currClient = await GetClientByID(id);
            _context.Remove(currClient);

            int rowsAffected = await _context.SaveChangesAsync();
            return rowsAffected > 0;
        }
    }
}
