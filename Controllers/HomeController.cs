using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiWebPersonal_Alessi.Models;

namespace MiWebPersonal_Alessi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.sobremi = Datos.SobreMi;
        return View();
    }

    public IActionResult proyectos()
    {
        ViewBag.proyectos = Datos.Proyectos;
        ViewBag.DescProyecto1 = Datos.descproyecto1;
        ViewBag.DescProyecto2 = Datos.descproyecto2;
        ViewBag.DescProyecto3 = Datos.descproyecto3;
        return View();
    }

    public IActionResult SobreMi()
    {
        ViewBag.Deportes = Datos.deportes;
        ViewBag.idiomas = Datos.Idiomas;
        ViewBag.colegios = Datos.Colegios;
        ViewBag.Comidas = Datos.comidas;
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
