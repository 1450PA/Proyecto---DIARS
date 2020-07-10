using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using GestionBienes.BD;
using GestionBienes.Extensiones;
using GestionBienes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GestionBienes.Controllers
{
    public class MovimientoController : Controller
    {
        [HttpGet]
        public IActionResult _RetirarBien()
        {
            var context = new ConexionBaseDeDatos();
            var model = context.Bienes.Include(o => o.Movimientos).ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult _IngresarBien()
        {
            var context = new ConexionBaseDeDatos();
            var model = context.Bienes.Include(o => o.Movimientos).ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult AgregarExistencias(int IdBien)
        {
            var context = new ConexionBaseDeDatos();

            var model = context.Bienes.Where(o => o.Id == IdBien).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public IActionResult AgregarExistencias(int IdBien, Movimiento movimiento)
        {
            var context = new ConexionBaseDeDatos();
            var usuario = HttpContext.Session.Get<Usuario>("SessionLoggedUser");

            var bien = context.Bienes.Where(o => o.Id == IdBien).FirstOrDefault();

            bien.CantidadActual += movimiento.Cantidad;

            movimiento.IdUsuario = usuario.Id;
            movimiento.IdBien = IdBien;
            movimiento.Fecha = DateTime.Now;
            context.Add(movimiento);
            context.SaveChanges();
            return RedirectToAction("Index", "Bien");
        }

        [HttpGet]
        public IActionResult RetirarExistencias(int IdBien)
        {
            var context = new ConexionBaseDeDatos();

            var model = context.Bienes.Where(o => o.Id == IdBien).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public IActionResult RetirarExistencias(int IdBien, Movimiento movimiento)
        {
            var context = new ConexionBaseDeDatos();
            var usuario = HttpContext.Session.Get<Usuario>("SessionLoggedUser");

            var bien = context.Bienes.Where(o => o.Id == IdBien).FirstOrDefault();

            bien.CantidadActual -= movimiento.Cantidad;

            movimiento.IdUsuario = usuario.Id;
            movimiento.IdBien = IdBien;
            movimiento.Fecha = DateTime.Now;
            context.Add(movimiento);
            context.SaveChanges();
            return RedirectToAction("Index", "Bien");
        }

    }
}