using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionBienes.Models
{
    public class Historial
    {
        public int IdBien { get; set; }
        public int TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public int UnidadMedida { get; set; }
    }
}
