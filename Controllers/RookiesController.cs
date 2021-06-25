using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;

namespace MVC.Controllers
{
    public class RookiesController : Controller
    {
        private readonly ILogger<RookiesController> _logger;
        public RookiesController(ILogger<RookiesController> logger)
        {
            _logger = logger;
        }

        static List<Person> persons = new List<Person>{
            new Person{
                Id = 1,
                FirstName = "Long",
                LastName = "Bao",
                Gender = "Male",
                DateOfBirth = new DateTime(1994,1,16),
                BirthPlace = "Bac Ninh",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Person{
                Id = 2,
                FirstName = "Hung",
                LastName = "Ngo Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1991,3,7),
                BirthPlace = "Hai Phong",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Person{
                Id = 3,
                FirstName = "Van",
                LastName = "Nguyen Cuong",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,3,7),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Person{
                Id = 4,
                FirstName = "Hao Nhien",
                LastName = "Thang",
                Gender = "Male",
                DateOfBirth = new DateTime(2020,11,13),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Person{
                Id = 5,
                FirstName = "Lan Phuong",
                LastName = "Nguyen",
                Gender = "Female",
                DateOfBirth = new DateTime(1991,8,8),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            }
        };

        public IActionResult Index()
        {
            return View(persons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person model)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.Error = "Invalid model !!!";
                return View();
            }

            int id = 0;

            if(!persons.Any()) {

                id = 1;

            } else {

                var personMaxId = persons.OrderByDescending(person => person.Id).First();

                id = personMaxId.Id++;

            }

            model.Id = id;

            persons.Add(model);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var model = persons.FirstOrDefault(person => person.Id == id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Person model)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.Error = JsonSerializer.Serialize(model);
                return View();
            }

            var list = persons.Where(person => person.Id != model.Id).ToList();

            list.Insert(0, model);

            persons = list;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = persons.FirstOrDefault(person => person.Id == id);

            var list = persons.Where(m => m.Id != model.Id).ToList();

            persons = list; 

            return RedirectToAction("Index");
        }

        public IActionResult GetAllMale()
        {
            var list = persons.Where(person => person.Gender == "Male").ToList();
           
            return Json(list);
        }

        public IActionResult GetFirstOldest()
        {
            var oldestAge = persons.Select(person => person.Age).Max();

            var oldest = persons.Where(person => person.Age == oldestAge).FirstOrDefault();

            return Json(oldest);
        }

        public IActionResult GetFullNames()
        {
            var list = persons.Select(person => {
                return person.FullName;
            }).ToList();

            return Json(list);
        }

        public IActionResult GetPersonsBirthYearEqual(int yearOfBirth)
        {
            var list = persons.Where(person => person.DateOfBirth.Year == 2000).ToList();

            return Json(list);
        }

        public IActionResult GetPersonsBirthYearGreater(int yearOfBirth)
        {
            var list = persons.Where(person => person.DateOfBirth.Year > 2000).ToList();

            return Json(list);
        }

        public IActionResult GetPersonsBirthYearLess(int yearOfBirth)
        {
            var list = persons.Where(person => person.DateOfBirth.Year < 2000).ToList();

            return Json(list);
        }

        public IActionResult FillterPerson(int yearOfBirth, string type)
        {
            switch(type) {

                case "equal": 

                    return GetPersonsBirthYearEqual(yearOfBirth);

                case "greater":

                    return GetPersonsBirthYearGreater(yearOfBirth);

                case "less":

                    return GetPersonsBirthYearLess(yearOfBirth);

                default:
                
                    return new EmptyResult();
            }
        }

        public IActionResult ExportListToExcel()
        {
            var builder = new StringBuilder();

            builder.AppendLine("Fullname,Gender, Age, Phone number");
            
            foreach (var person in persons)
            {
                builder.AppendLine($"{person.FullName},{person.Gender},{person.Age},{person.PhoneNumber}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "persons.csv");
        }

    }
}