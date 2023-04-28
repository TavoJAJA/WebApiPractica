using Microsoft.AspNetCore.Mvc;

namespace WebApiPractica.Controllers
{
    public class EquiposHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
