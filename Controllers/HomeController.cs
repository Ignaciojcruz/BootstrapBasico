using IntroduccionABootstrap.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntroduccionABootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Alineacion()
        {
            return View();
        }

        public IActionResult Grid()
        {
            return View();
        }

        public IActionResult Gutter()
        {
            return View();
        }

        public IActionResult Offset() 
        {
            return View();
        }

        public IActionResult Imagenes() 
        {
            return View();
        }

        public IActionResult Colores()
        {
            return View();
        }

        public IActionResult Tablas()
        {
            return View();
        }

        public IActionResult Video() 
        {
            return View();
        }

        public IActionResult Sizes()
        {
            return View();
        }

        public IActionResult Margenes() 
        {
            return View();
        }

        public IActionResult Textos()
        {
            return View();
        }

        public IActionResult Formulario() 
        {
            return View();
        }

        public IActionResult Acordeon() 
        {
            return View();
        }

        public IActionResult Alertas() 
        {
            return View();
        }

        public IActionResult Carousel() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}