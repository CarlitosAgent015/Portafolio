using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using razor_mvc.Models;

namespace razor_mvc.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;
    private readonly RepositorioProyectos repositorioProyectos;
    public HomeController(ILogger<HomeController> logger, RepositorioProyectos repositorioProyectos)
    {
    _logger = logger;
        this.repositorioProyectos = repositorioProyectos;
}

    public IActionResult Index()
    {
        //var RepositorioProyectos = new RepositorioProyectos();
        var proyectos=repositorioProyectos.ObtenerProyectos().Take(4).ToList();
        var modelo = new HomeIndexViewModel() { Proyectos = proyectos};
        return View(modelo);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
