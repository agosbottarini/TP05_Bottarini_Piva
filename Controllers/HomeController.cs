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

    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala != Escape.GetEstadoJuego())
        {
            return View("Habitacion"+Escape.GetEstadoJuego());
        }
        else
        {
            if(Escape.ResolverSala(sala,clave))
            {
                
                if(Escape.GetEstadoJuego() == 4)
                {
                    return View();
                }
                return View("Habitacion"+Escape.GetEstadoJuego()+1);
            }
            else
            {
                ViewBag.Error = "La respuesta fue incorrecta";
                return View("Habitacion"+Escape.GetEstadoJuego());
            }
        }
    }
}
