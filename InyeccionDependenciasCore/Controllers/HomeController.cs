using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InyeccionDependenciasCore.Models;

namespace InyeccionDependenciasCore.Controllers
{
    public class HomeController : Controller
    {
        private IAnimal animal;
        public HomeController(IAnimal animal)
        {
            this.animal = animal;
        }
        public IActionResult Index()
        {
            ViewData["Caminar"] = this.animal.Caminar();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
