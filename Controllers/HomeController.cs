using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.DiccPaquetes = OrtWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete(){
        ViewBag.Paquete = OrtWorld.Paquetes;
        ViewBag.ListaHoteles = OrtWorld.ListaHoteles;
        ViewBag.ListaAereos = OrtWorld.ListaAereos;
        ViewBag.ListaExcursiones = OrtWorld.ListaExcursiones;

        return View();
    }

   public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion){
        Paquetes paquete1 = new Paquetes(OrtWorld.ListaHoteles[Hotel],OrtWorld.ListaAereos[Aereo],OrtWorld.ListaExcursiones[Excursion]);
       if (Destino <= 0 || Hotel <= 0 || Aereo <=0 || Excursion <= 0)
       {
        ViewBag.ErrorMensaje = "Debe proporcionar todos los parámetros requeridos";
        return View("selectPaquete");
       }
       OrtWorld.IngresarPaquete(OrtWorld.ListaDestinos[Destino], paquete1);
       return View();
    }
}
