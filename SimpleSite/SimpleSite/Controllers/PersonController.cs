using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angela.Core;
using SimpleSite.Models;

namespace SimpleSite.Controllers
{
    public class PersonController : BaseController
    {
        private static ICollection<Person> _people;

        static PersonController()
        {
            _people = Angie.Configure<Person>()
                .Fill(p => p.BirthDate)
                .AsPastDate()
                .Fill(p => p.LikesMusic)
                .WithRandom(new List<bool>() { true, true, true, false, false })
                .Fill(p => p.Skills, () => new List<string>() { "Math", "Science", "History" })
                .MakeList<Person>(20);
        }

        // GET: Person
        public ActionResult Index()
        {
            return View(_people);
        }

        public ActionResult SearchPeople(string searchText)
        {
            var term = searchText.ToLower();
            var result = _people
                .Where(p =>
                    p.FirstName.ToLower().Contains(term) ||
                    p.LastName.ToLower().Contains(term)
                );

            return PartialView("_SearchPeople", result);
        }

        public ActionResult Create()
        {
            var person = new Person();
            return View(person);
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _people.Add(person);
                Success(string.Format("<b>{0}</b> was successfully added to the database.", person.FirstName), true);
                return RedirectToAction("Index");
            }
            Danger("Looks like something went wrong. Please check your form.");
            return View(person);
        }

    }
}