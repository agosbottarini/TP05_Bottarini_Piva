using Microsoft.AspNetCore.Mvc;

namespace TP05_Bottarini_Piva.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
