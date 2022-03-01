using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidacionFormularios.Models;

namespace ValidacionFormularios.Controllers
{
    public class ValidarFormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            if (usuario.IsValid(usuario))
            {
                ViewBag.Mensaje = "Usuario correcto.";
                return View();
            }
            else
            {
                ViewBag.Mensaje = "No tiene edad suficiente para acceder.";
                return View();
            }
        }
    }
}
