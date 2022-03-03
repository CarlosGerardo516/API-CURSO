using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingCore.Entities;

namespace ParkingInfrastructure.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.HasKey(e => e.IdCliente);

            builder.ToTable("TB_CLIENTES");

            builder.HasIndex(e => e.Placa)
                    .HasName("UQ__TB_CLIEN__E441AE001C206E7E")
                    .IsUnique()
                    ;

            builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

            builder.Property(e => e.FechaAcceso)
                    .HasColumnName("FECHA_ACCESO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.HoraAcceso)
                    .HasColumnName("HORA_ACCESO")
                    .HasDefaultValueSql("(sysdatetime())");

            builder.Property(e => e.TipCliente).HasColumnName("ID_TIPOCLTE");

            builder.Property(e => e.Placa)
                    .IsRequired()
                    .HasColumnName("PLACA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

            builder.HasOne(d => d.TipoCliente)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.TipCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_CLIENT__ID_TI__29572725");
        }
    }
}
