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
        if (Juego.JuegoFinalizado())
        {
            if (Juego.Gano())
            {
                return RedirectToAction("Ganar");
            }
            else
            {
                return RedirectToAction("Perder");
            }
        }

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

        Juego.ArriesgarLetra(letraarriesgada[0]);
        return RedirectToAction("Jugar");
    }

    public IActionResult ArriesgarPalabra(string palabraarriesgada)
    {
        Juego.ArriesgarPalabra(palabraarriesgada);
        return RedirectToAction("Jugar");
    }

    public IActionResult Ganar()
    {
        return View();
    }

    public IActionResult Perder()
    {
        ViewBag.PalabraSecreta = Juego.GetPalabraSecreta();
        return View();
    }

    public IActionResult NuevoJuego()
    {
        Juego.NuevoJuego();
        return RedirectToAction("Jugar");
    }
}
