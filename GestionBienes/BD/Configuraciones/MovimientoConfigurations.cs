using GestionBienes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionBienes.BD.Configuraciones
{
    public class MovimientoConfigurations : IEntityTypeConfiguration<Movimiento>
    {
        public void Configure(EntityTypeBuilder<Movimiento> builder)
        {
            builder.ToTable("Movimiento");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.User)
                .WithMany(o => o.Movimientos)
                .HasForeignKey(o => o.IdUsuario);


            builder.HasOne(o => o.Bien)
                .WithMany(o => o.Movimientos)
                .HasForeignKey(o => o.IdBien);

        }
    }
}
