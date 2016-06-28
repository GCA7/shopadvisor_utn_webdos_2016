using Curriculum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curriculum.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            
            var query = db.Lenguajes.ToList();
            string data = "";
            foreach (var item in query)
            {
                data+= item.id + " " + item.name_lenguaje +" "+'\n';
            }
            ViewData["Lenguajes"] = data;

            var exp = db.Experiencias.ToList();
            string dato = "";
            foreach (var item in exp)
            {
                dato += item.id +" "+ item.titulo + " " + item.name + " " + item.detalles +" " + '\n';
            }
            ViewData["Experiencia"] = dato;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}