using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingInfrastructure.Data.Configurations
{
    public class TipoClienteConfiguration :IEntityTypeConfiguration<TipoClientes>
    {
        public void Configure (EntityTypeBuilder<TipoClientes> builder)
        {
            builder.HasKey(e => e.ID);

            builder.ToTable("TB_TIPOCLIENTE");

            builder.Property(e => e.ID).HasColumnName("ID_TIPO");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("NOM_TIPO")
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
