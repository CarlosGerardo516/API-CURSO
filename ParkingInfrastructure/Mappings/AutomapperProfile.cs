using AutoMapper;
using ParkingCore.DTOs;
using ParkingCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingInfrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Clientes, ClienteDto>();
            CreateMap<ClienteDto, Clientes>();
            CreateMap<TipoClienteDto, TipoClientes>();
            CreateMap<TipoClientes, TipoClienteDto>();
        }
    }
}
