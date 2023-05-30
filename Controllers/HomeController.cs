using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paises = Info.ListarPaises();
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult DetallePais(string nombrePais)
    {
        ViewBag.Pais = Info.DetallePais(nombrePais);
        return View();
    }
}
