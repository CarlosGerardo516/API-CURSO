using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingInfrastructure.Data.Configurations
{
    public class RegistroPensionConfiguration : IEntityTypeConfiguration<RegistroPension>
    {
        public void Configure(EntityTypeBuilder<RegistroPension> builder)
        {
            builder.HasKey(e => e.RegistroID);

            builder.ToTable("TB_REGISTROPENSION");

            builder.HasIndex(e => e.ClienteID)
                .HasName("UQ__TB_REGIS__23A34131FD7E2B67")
                .IsUnique();

            builder.Property(e => e.RegistroID).HasColumnName("ID_REG_PEN");

            builder.Property(e => e.FechaInicio)
                .HasColumnName("FECHA_INICIO")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.ClienteID).HasColumnName("ID_CLIENTE");

            builder.HasOne(d => d.Cliente)
                .WithOne(p => p.RegistroPension)
                .HasForeignKey<RegistroPension>(d => d.ClienteID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TB_REGIST__ID_CL__33D4B598");
        }
    }
}
