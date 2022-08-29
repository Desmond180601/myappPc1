using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myappPc1.Models;

namespace myappPc1.Controllers
{
    public class calculadoraController  : Controller
    {
        private readonly ILogger<calculadoraController > _logger;

        public calculadoraController (ILogger<calculadoraController > logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult calcular(calculadora objCalculadora)
        {
        ViewData["Message1"] = "Alumno: "+objCalculadora.Nombre; 

        double igv,Total,PagoTotal;
        int i = 0;

        if (objCalculadora.Matematica){
            i = i + 1;
        }if(objCalculadora.Lenguaje){
            i = i+1;
        }if (objCalculadora.Historia){
            i = i+1;
        }
            
        Total = i * (i * 100);
        igv = Total * 1.18;
        PagoTotal = Total + igv;

        ViewData["Message2"] = "Pagp total de los cursos: " + Total;
        ViewData["Message3"] = "IGV: " + igv;
        ViewData["Message4"] = "Total a pagar: " + PagoTotal;

        return View("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    } 
}