using System.Collections.Generic;
using System.Web.Mvc;
using ProyectoMVC5.Models;

namespace ProyectoMVC5.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            var persons = PersonDAL.List();
            return View(persons);
        }

    }
}