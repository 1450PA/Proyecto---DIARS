using GestionBienes.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionBienes.Models
{
    public class ControlMovimientos
    {

        public DateTime GetFechaLastEntrada(int IdBIen)
        {
            var context = new ConexionBaseDeDatos();

            var movimiento = context.Movimientos.Where(o => o.IdBien == IdBIen && o.TipoMovimiento == 0)
                .OrderByDescending(o => o.Fecha).FirstOrDefault();

            return movimiento.Fecha;
        }

        public DateTime GetFechaLastSalida(int IdBIen)
        {
            var context = new ConexionBaseDeDatos();

            var movimiento = context.Movimientos.Where(o => o.IdBien == IdBIen && o.TipoMovimiento == 1)
                .OrderByDescending(o => o.Fecha).FirstOrDefault();

            return movimiento.Fecha;
        }

    }
}
