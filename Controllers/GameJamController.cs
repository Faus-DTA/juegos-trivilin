using Microsoft.AspNetCore.Mvc;
using FORM.Models;

namespace FORM.Controllers
{
    public class GameJamController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Jugador jugador)
        {
            if (jugador.PagoMatricula)
            {
                ViewBag.Mensaje = "Registro completado correctamente";
            }
            else
            {
                ViewBag.Mensaje = "Ud aun no ha completado su pago";
            }

            return View("~/Views/Home/Index.cshtml");
        }
    }
}