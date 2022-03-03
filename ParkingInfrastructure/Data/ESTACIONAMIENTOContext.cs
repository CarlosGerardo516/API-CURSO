using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ParkingCore.Entities;
using ParkingInfrastructure.Data.Configurations;

namespace ParkingInfrastructure.Data
{
    public partial class ESTACIONAMIENTOContext : DbContext
    {
        public virtual DbSet<Clientes> Clients { get; set; }
        public virtual DbSet<RegistroEstacionamiento> Registros { get; set; }
        public virtual DbSet<RegistroPension> RegistrosPension { get; set; }
        public virtual DbSet<TipoClientes> TiposCliente { get; set; }
        public ESTACIONAMIENTOContext()
        {
        }
        public ESTACIONAMIENTOContext(DbContextOptions<ESTACIONAMIENTOContext> options)
            : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());

            modelBuilder.ApplyConfiguration(new RegistroEstacionamientoConfiguration());

            modelBuilder.ApplyConfiguration(new RegistroPensionConfiguration());

            modelBuilder.ApplyConfiguration(new TipoClienteConfiguration());
        }
    }
}
