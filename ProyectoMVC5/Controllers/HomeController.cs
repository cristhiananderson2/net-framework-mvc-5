using System.Collections.Generic;
using System.Web.Mvc;
using ProyectoMVC5.Models;

namespace ProyectoMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Cristhian Anderson",
                    LastName = "Gómez Culquichicoin"
                },
            };

            ViewBag.L_PERSONS = persons; //No persiste entre métodos
            TempData["L_PERSON_2"] = persons;

            return View();
        }

    }
}