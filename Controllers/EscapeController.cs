using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using salaEscape.Models;

namespace salaEscape.Controllers
{
    public class EscapeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public IActionResult habitacion1()
        {
            return View();
        }
        
        public IActionResult habitacion2()
        {
            return View();
        }

        public IActionResult habitacion3()
        {
            return View();
        }
         public IActionResult habitacion4()
        {
            return View();
        }
        [HttpPost]
        public IActionResult habitacion1 (string Respuesta){
            string upper=Respuesta.ToUpper();
            if(upper=="DANI CALIFORNIA"){
                return View("habitacion2");
            }
            else{
                return View();
            }
        }
       [HttpPost]
        public IActionResult habitacion2 (string Respuesta){
            string upper2=Respuesta.ToUpper();
            if(upper2=="PARADISE CITY"){
                return View("habitacion3");
            }
            else{
                return View();
            }
        }
        [HttpPost]
        public IActionResult habitacion3 (string Respuesta){
            string upper3=Respuesta.ToUpper();
            if(upper3=="STRAIGHT OUTTA COMPTON"){
                return View("habitacion4");
            }
            else{
                return View();
            }
        }
    [HttpPost]
        public IActionResult habitacion4 (string Respuesta){
            string upper4=Respuesta.ToUpper();
            if(upper4=="1994"){
                return View("felicitaciones");
            }
            else{
                return View();
            }
        }
        public IActionResult felicitaciones(){
            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
