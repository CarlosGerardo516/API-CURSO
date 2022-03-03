using ParkingCore.Entities;
using ParkingCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCore.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClientesRepository _clientRepository;
        private readonly ITipoClienteRepository _TipoCltRepository;
        public ClienteService(IClientesRepository cltRepository,
            ITipoClienteRepository tipoClienteRepo)
        {
            _clientRepository = cltRepository;
            _TipoCltRepository = tipoClienteRepo;
        }

        public async Task<bool> DeleteCliente(int id)
        {
            return await _clientRepository.DeleteCliente(id);
        }

        public async Task<Clientes> GetClientByID(int id)
        {
            var client = await _clientRepository.GetClientByID(id);
            var tipo = await _TipoCltRepository.GetTipoByID(client.TipCliente);
            if (client.TipCliente == 1)
            {
                throw new Exception("El cliente no cuenta con tipo de cliente y se tomara como cliente normal.");
            }
            client.TipoCliente = tipo;
            return client;
        }

        public async Task<IEnumerable<Clientes>> GetClientes()
        {
            return await _clientRepository.GetClientes();
        }

        public async Task<Clientes> GetCobroTotal(Clientes cliente)
        {
            var diferenciaMinutos = DateTime.Now.TimeOfDay.Subtract(cliente.HoraAcceso).TotalMinutes;
            cliente.GetCobroEstacionamiento(diferenciaMinutos);
            return await _clientRepository.GetClientByID(cliente.IdCliente);
        }

        public async Task InsertClient(Clientes clt)
        {
           await _clientRepository.InsertClient(clt);
        }

        public async Task<bool> updateCliente(Clientes clt)
        {
            return await _clientRepository.updateCliente(clt);
        }
    }
}
