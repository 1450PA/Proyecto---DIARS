using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionBienes.BD;
using GestionBienes.Models;
using GestionBienes.Extensiones;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace GestionBienes.Controllers
{
    public class BienController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var context = new ConexionBaseDeDatos();
            var model = context.Bienes.Include(o => o.Movimientos).ToList();

            var usuario = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            ViewBag.NombreUsuario = usuario.Nombres;

            if (model.Count == 0)
            {
                return View("SinBienes");
            }

            return View(model);
        }

        [HttpGet]
        public ViewResult IngresarBienNoRegistrado(){return View();}

        [HttpPost]
        public IActionResult IngresarBienNoRegistrado(Movimiento movimiento, Bien bien)
        {
            var context = new ConexionBaseDeDatos();

            bien.Codigo = bien.GenerarCodigo(bien);
            bien.CantidadActual += movimiento.Cantidad; 

            context.Add(bien);
            context.SaveChanges();

            var usuario = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            movimiento.IdUsuario = usuario.Id;
            
            movimiento.IdBien = bien.Id;
            movimiento.Fecha = DateTime.Now;
            context.Add(movimiento);

            context.SaveChanges();

            return RedirectToAction("Index","bien");
        }

        public IActionResult Movimientos(int IdBien)
        {
            var context = new ConexionBaseDeDatos();
            var model = context.Movimientos.Where(o => o.IdBien == IdBien).ToList();
            ViewBag.Bien = context.Bienes.Where(o => o.Id == IdBien).FirstOrDefault();

            return View(model);
        }
    }
}