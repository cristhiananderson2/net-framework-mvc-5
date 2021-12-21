using System.Collections.Generic;
using System.Web.Mvc;
using ProyectoMVC5.Models;

namespace ProyectoMVC5.Controllers
{
    public class PersonController : Controller
    {
        public static List<Person> persons =  new List<Person>();

        [HttpGet]
        public ActionResult Index()
        {
            var persons = PersonDAL.List();
            return View(persons);
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(persons);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person obj)
        {
            obj.Id = persons.Count + 1;
            persons.Add(obj);

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var person = persons.Find(x => x.Id == id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person obj)
        {
            var person = persons.Find(x => x.Id == obj.Id);
            person.Name = obj.Name;
            person.LastName = obj.LastName;

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            persons.RemoveAll(x => x.Id == id);
          
            return RedirectToAction("List");
        }

    }
}