using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidacionFormularios.Models;
using ValidacionFormularios.Repositories;

namespace ValidacionFormularios.Controllers
{
    public class ValidarFormularioController : Controller
    {
        private RepositoryUsuarios repo;
        public ValidarFormularioController(RepositoryUsuarios repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            ValidarUsuario validarUsuario = new ValidarUsuario();
            return View(validarUsuario);
        }

        [HttpPost]
        public IActionResult Index(ValidarUsuario validarUsuario /*string nombre, string apellidos, int edad, string email, string contrasenia, string confirmarContrasenia*/)
        {
            if (ModelState.IsValid)
            {
                this.repo.CreateUsuario(validarUsuario.Nombre, validarUsuario.Apellidos, validarUsuario.Edad, validarUsuario.Email, validarUsuario.Contrasenia, validarUsuario.ConfirmarContrasenia);
                TempData["email"] = validarUsuario.Email;
                return RedirectToAction("DatosUsuario", "ValidarFormulario");
            }
            return View();

            /*if (usuario.IsValid(usuario))
            {
                this.repo.CreateUsuario(nombre, apellidos, edad, email, contrasenia, confirmarContrasenia);
                TempData["email"] = email;
                return RedirectToAction("DatosUsuario", "ValidarFormulario");
            }
            else
            {
                ViewBag.Mensaje = "No tienes edad suficiente para acceder.";
                return View();
            }*/
        }

        public IActionResult DatosUsuario()
        {
            string email = TempData["email"].ToString();
            Usuario usuario = this.repo.FindUsuario(email);
            return View();
        }
    }
}
