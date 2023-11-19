using Microsoft.AspNetCore.Mvc;

namespace SistemaDeCadastro.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
