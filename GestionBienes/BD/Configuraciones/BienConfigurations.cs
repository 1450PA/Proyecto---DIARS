using GestionBienes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionBienes.BD.Configuraciones
{
    public class BienConfigurations : IEntityTypeConfiguration<Bien>
    {
        public void Configure(EntityTypeBuilder<Bien> builder)
        {
            builder.ToTable("Bien");
            builder.HasKey(o => o.Id);

        }
    }
}
