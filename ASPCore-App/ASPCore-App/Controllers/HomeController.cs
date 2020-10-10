using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore_App.Models;

namespace ASPCore_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var a = new AlumnoModel();
            a.Nombre = "Omar";
            a.App = "Nava";
            a.Apm = "Gonzalez";
            a.Carrera = "Informatica";
            a.NC = "17030098";
            a.Promedio = "90";
            /////////////////////////
            a.Nombre_2 = "Saul";
            a.App_2 = "Burciaga";
            a.Apm_2 = "Hernandez";
            a.Carrera_2 = "Informatica";
            a.NC_2 = "17030078";
            a.Promedio_2 = "95";
            ///////////////////////////
            a.Nombre_3 = "Luis";
            a.App_3 = "Mendieta";
            a.Apm_3 = "Hernandez";
            a.Carrera_3 = "Informatica";
            a.NC_3 = "17030065";
            a.Promedio_3 = "88";
            //////////////////////////
            a.Nombre_4 = "J. Carlos";
            a.App_4 = "Magallanes";
            a.Apm_4 = "Orona";
            a.Carrera_4 = "Informatica";
            a.NC_4 = "17030075";
            a.Promedio_4 = "83";

            return View(a);
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
}
