using Microsoft.AspNetCore.Mvc;

namespace TP05_Bottarini_Piva.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Comenzar()
    {
        return View("Habitacion"+Escape.GetEstadoJuego());
    }

    public IActionResult dondeEncontrarnos()
    {
        return View();
    }
    public IActionResult comoContactarnos()
    {
        return View();
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala == Escape.GetEstadoJuego())
        {
            if(Escape.ResolverSala(sala,clave))
            {
                if(Escape.GetEstadoJuego() == 4) 
                return View("Victoria");
            }
            else 
            ViewBag.Error = "La respuesta fue incorrecta";
        }
        return View("Habitacion"+Escape.GetEstadoJuego());
    }
}
