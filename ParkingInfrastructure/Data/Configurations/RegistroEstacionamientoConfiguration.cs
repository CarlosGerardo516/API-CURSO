using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingInfrastructure.Data.Configurations
{
    public class RegistroEstacionamientoConfiguration : IEntityTypeConfiguration<RegistroEstacionamiento>
    {
        public void Configure(EntityTypeBuilder<RegistroEstacionamiento> builder)
        {
            builder.HasKey(e => e.ID);

            builder.ToTable("TB_REGISTRO_PARKING");

            builder.Property(e => e.ID).HasColumnName("ID_REGISTRO");

            builder.Property(e => e.FechaAcceso)
                .HasColumnName("FECHA_ACCESO")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.FechaSalida)
                .HasColumnName("FECHA_SALIDA")
                .HasColumnType("datetime");

            builder.Property(e => e.HoraAcceso)
                .HasColumnName("HORA_ACCESO")
                .HasDefaultValueSql("(sysdatetime())");

            builder.Property(e => e.HoraSalida).HasColumnName("HORA_SALIDA");

            builder.Property(e => e.ClienteID).HasColumnName("ID_CLIENTE");

            builder.Property(e => e.TotalCobro).HasColumnName("TOTAL_COBRO");
        }
    }
}
