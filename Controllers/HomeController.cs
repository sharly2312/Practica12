using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica12._2.Models;

namespace practica12._2.Controllers
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
        [HttpPost]
        public ActionResult Index(string numero1, string numero2, string tipo )

        {
            int a = Convert.ToInt32(numero1);
            int b = Convert.ToInt32(numero2);
            int c = 0;
            if(tipo=="Rectangulo")
            {
                c=a*b/2;
                ViewBag.Resultado = c;
            }
            else
            {
                ViewBag.Resultado = c;
            }
            if(tipo=="Triangulo")
            {
                c=a*b/2;
                ViewBag.Resultado = c;
            }
            else
            {
                ViewBag.Resultado =c;

            }
            

          return View();
        }

        public IActionResult Privacy()
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
