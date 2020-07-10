using GestionBienes.BD.Configuraciones;
using GestionBienes.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionBienes.BD
{
    public class ConexionBaseDeDatos : DbContext
    {
        public DbSet<Bien> Bienes { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-TDC7EBH; Database = GestionBienes; Trusted_Connection = True; MultipleActiveResultSets = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioConfigurations());
            modelBuilder.ApplyConfiguration(new BienConfigurations());
            modelBuilder.ApplyConfiguration(new MovimientoConfigurations());

        }
    }
}
