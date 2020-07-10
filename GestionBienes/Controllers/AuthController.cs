using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using GestionBienes.BD;
using GestionBienes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using GestionBienes.Extensiones;

namespace GestionBienes.Controllers
{
    public class AuthController : Controller
    {
        private IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {
            var context = new ConexionBaseDeDatos();
            this.configuration = configuration;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var context = new ConexionBaseDeDatos();

            var user = context.Usuarios.FirstOrDefault(o => o.Username == username && o.Password == GetHashedPassword(password));

            if (user == null)
                return View();

            HttpContext.Session.Set("SessionLoggedUser", user);

            var claims = new List<Claim>() {
                new Claim(ClaimTypes.Name, user.Username),
            };

            var userIdentity = new ClaimsIdentity(claims, "login");
            var principal = new ClaimsPrincipal(userIdentity);

            HttpContext.SignInAsync(principal);

            return RedirectToAction("Index", "Bien");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Usuario user)
        {
            var context = new ConexionBaseDeDatos();

            if (ModelState.IsValid)
            {
                user.Password = GetHashedPassword(user.Password);
                context.Usuarios.Add(user);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        private string GetHashedPassword(string password)
        {
            string token = configuration.GetValue<string>("Token");
            password += token;
            var sha = SHA256.Create();
            var hashData = sha.ComputeHash(Encoding.Default.GetBytes(password));
            return Convert.ToBase64String(hashData);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }

    }
}
