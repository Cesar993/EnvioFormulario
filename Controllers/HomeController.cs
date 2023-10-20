using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EnvioFormularios.Models;

namespace EnvioFormularios.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet("success")]
    public IActionResult Success()
    {
        return View("Success");
    }

    [HttpPost]
    [Route("usuario/registrar")]
    public IActionResult UsuarioRegistrado(User nuevoUser)
    {

        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");

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
