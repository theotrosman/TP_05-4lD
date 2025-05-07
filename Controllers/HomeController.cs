using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_05_4ID.Models;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        Juego.NuevoJuego();
        return View();
    }
    public IActionResult Jugar()
    {
        ViewBag.Palabra = Juego.GetPalabraParcial();
        ViewBag.Letras = Juego.GetLetrasUsadas();
        ViewBag.Intentos = Juego.GetIntentos();
        ViewBag.Finalizado = Juego.JuegoFinalizado();
        ViewBag.Gano = Juego.Gano();
        ViewBag.PalabraSecreta = Juego.GetPalabraSecreta();

        return View();

    }

    public IActionResult ArriesgarLetra(string letraarriesgada)
    {

        if (!string.IsNullOrEmpty(letraarriesgada))
        {
            Juego.ArriesgarLetra(letraarriesgada[0]);
        }
        return RedirectToAction("Jugar");
    }

    public IActionResult ArriesgarPalabra(string palabraarriesgada)
    {

        if (!string.IsNullOrEmpty(palabraarriesgada))
        {
            Juego.ArriesgarPalabra(palabraarriesgada);
        }


        return RedirectToAction("Jugar");
    }

    public IActionResult NuevoJuego()
    {
        Juego.NuevoJuego();
        return RedirectToAction("Jugar");
    }
}