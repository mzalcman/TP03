using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TРОЗ.Models;

namespace TРОЗ.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        GestorDiscos.InicializarDiscos();
        ViewBag.DiccionarioDiscos = GestorDiscos.Discos;
        return View();
    }

    public IActionResult SelectDisco(int id)
    {
        Dictionary<int, Disco> diccionarioDisco = GestorDiscos.Discos;
        if(diccionarioDisco.ContainsKey(id))
        {
            ViewBag.infoDatosDiscoBuscado = diccionarioDisco[id];
            ViewBag.ID = id;
        }
        return View("infoDatosDiscoBuscado","id");
    }
}
