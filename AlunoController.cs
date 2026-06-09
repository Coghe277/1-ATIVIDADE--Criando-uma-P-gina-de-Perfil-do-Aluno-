using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Joao Pedro";
            ViewBag.Curso = "Analise de Sistemas";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.IdAluno = id;
            
            return View();
        }
    }
}
