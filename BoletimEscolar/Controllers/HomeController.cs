using Microsoft.AspNetCore.Mvc;
using BoletimEscolar.Models;
using System.Collections.Generic;

namespace BoletimEscolar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Boletim");
        }

        public IActionResult Boletim()
        {
            List<DisciplinaNota> boletim = new List<DisciplinaNota>
            {
                new DisciplinaNota { Nome = "Programação C#", Nota = 9.5 },
                new DisciplinaNota { Nome = "Banco de Dados", Nota = 6.2 },
                new DisciplinaNota { Nome = "Engenharia de Software", Nota = 7.8 },
                new DisciplinaNota { Nome = "Sistemas Operacionais", Nota = 4.5 }
            };

            ViewBag.BoletimCompleto = boletim;

            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }
    }
}
