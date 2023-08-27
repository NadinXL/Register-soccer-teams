using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1_Teoria.Models;

namespace PC1_Teoria.Controllers
{
    public class JugadorController : Controller
    {
        private readonly ILogger<JugadorController> _logger;

        public JugadorController(ILogger<JugadorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Jugador objJugador)
        {
            string respuesta;

            try
            {
                respuesta = objJugador.CalcularCostoTotal().ToString();
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            ViewData["Message"] = "Datos del Jugador: Equipo: " +objJugador.Equipo + "\nNombre: " + objJugador.Nombre + "\nEdad: "+ objJugador.Edad +"\nGénero: " + objJugador.Genero + "\nCategoría: "+objJugador.Categoria +"\nMonto total a pagar: " + respuesta;
            return View("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}