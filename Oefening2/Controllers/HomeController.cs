using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace Oefening2.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = {"Broccoli", "Spruitjes", "Wortels", "Spinazie" };
        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeienamiddag";
            return View();
        }
        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.Zoekresultaat = $"de gezochte groente is de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
            }
            
            return View();
        }

        public ViewResult Student()
        {
            List<Student> studenten = new List<Student>
            {
                new Student { Id = 23, Naam = "Jeff", AfstudeerGraad = Graad.voldoening },
                new Student { Id = 21, Naam = "Marie", AfstudeerGraad = Graad.Onderscheiding},
            };
            ViewBag.Studenten = studenten;
            return View();
        }
    }
}