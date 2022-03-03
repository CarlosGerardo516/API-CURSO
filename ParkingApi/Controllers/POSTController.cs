using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParkingApi.Response;
using ParkingCore.DTOs;
using ParkingCore.Entities;
using ParkingCore.Interfaces;
using ParkingCore.Repositories;
using ParkingCore.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POSTController : ControllerBase
    {
        private readonly IClienteService _clientService;
        private readonly IMapper _mapper;
        public POSTController(IClienteService clienteServ, IMapper mapper)
        {
            _clientService = clienteServ;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            var cltes = await _clientService.GetClientes();
            var cltDto = _mapper.Map<IEnumerable<ClienteDto>>(cltes);

            var response = new ApiResponse<IEnumerable<ClienteDto>>(cltDto);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientByID(int id)
        {
            var clt = await _clientService.GetClientByID(id);
            var cltDto = _mapper.Map<ClienteDto>(clt);

            var response = new ApiResponse<ClienteDto>(cltDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> InsertNewClient(ClienteDto cltDto)
        {
            var client = _mapper.Map<Clientes>(cltDto);
            await _clientService.InsertClient(client);
            cltDto = _mapper.Map<ClienteDto>(client);

            var response = new ApiResponse<ClienteDto>(cltDto);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, ClienteDto clteDto)
        {
            var client = _mapper.Map<Clientes>(clteDto);
            client.IdCliente = id;
            var result = await _clientService.updateCliente(client);

            var response = new ApiResponse<bool>(result);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _clientService.DeleteCliente(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
