using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionBienes.Models
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int IdBien { get; set; }
        public int IdUsuario { get; set; }
        public int TipoMovimiento { get; set; }
        public string Lugar { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string? TipoDocumento { get; set; }
        public string PersonaLleva { get; set; }

        public Bien Bien { get; set; }
        public Usuario User { get; set; }
    }
}
