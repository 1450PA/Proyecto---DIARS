using GestionBienes.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace GestionBienes.Models
{
    public class Bien
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Codigo { get; set; }
        public int UnidadMedida { get; set; }
        public int CantidadActual { get; set; }
        public int Tipo { get; set; }

        public List<Movimiento> Movimientos { get; set; }

        //public int BienCantidad(int IdBien)
        //{
        //    var context = new ConexionBaseDeDatos();
        //    var movimientos = context.Movimientos.Where(o => o.IdBien == IdBien).ToList();

        //    if (movimientos.Count() != 0)
        //    {
        //        return movimientos.Last().Cantidad;
        //    }

        //    return 0;
        //}

        public string UltimaEntrada(int IdBien)
        {
            var context = new ConexionBaseDeDatos();
            DateTime lastEntrada = new DateTime();
            lastEntrada = context.Movimientos.Where(o => o.TipoMovimiento == 0).Where(o => o.IdBien == IdBien).Max(o => o.Fecha);

            return lastEntrada.ToString();
        }

        public string UltimaSalida(int IdBien)
        {

            var fechaSalida = ConsultaSalida(IdBien);
            
            return fechaSalida.Year == 1000 ? "No se han registrado Retiros" : fechaSalida.ToString();
        }

        public DateTime ConsultaSalida(int IdBien)
        {
            var context = new ConexionBaseDeDatos();

            var movimientos = context.Movimientos.Where(o => o.TipoMovimiento == 1).Where(o => o.IdBien == IdBien).ToList();

            if (movimientos.Count() != 0) {
                return movimientos.Max(o => o.Fecha);
            }

            return new DateTime(1000, 1, 1);
        }

        public string GenerarCodigo(Bien bien)
        {
            string codigo = "Mat-";
            int i = 0;
            while (i < 3)
            {
                codigo += bien.Nombre[i];
                i++;
            }
            return codigo;
        }
    }
}
