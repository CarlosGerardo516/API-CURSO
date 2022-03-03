using FluentValidation;
using ParkingCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingInfrastructure.Validators
{
    public class ClienteValidator : AbstractValidator<Clientes>
    {
        public ClienteValidator()
        {
            RuleFor(cliente => cliente.Placa)
                .NotNull()
                .Length(8, 15);
        }
    }
}
