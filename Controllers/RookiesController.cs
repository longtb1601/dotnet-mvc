using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using MVC.Services;

namespace MVC.Controllers
{
    public class RookiesController : Controller
    {
        private readonly ILogger<RookiesController> _logger;
        private readonly IPersonService _personService;
        public RookiesController(ILogger<RookiesController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public IActionResult Index()
        {
            var persons = _personService.GetAll();

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

            _personService.Create(model);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var model = _personService.GetOne(id);

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

            _personService.Edit(model);

            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            var model = _personService.GetOne(id);

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var person = _personService.GetOne(id);

            HttpContext.Session.SetString($"SESSION_PERSON_{id}", person.FullName);

            _personService.Delete(id);

            return RedirectToAction("Result", new { id = id });
        }

        public IActionResult Result(int id)
        {
            var deletedPerson = HttpContext.Session.GetString($"SESSION_PERSON_{id}");
        
            ViewBag.deletedPerson = deletedPerson;

            return View();
        }

        // public IActionResult GetAllMale()
        // {
        //     var list = persons.Where(person => person.Gender == "Male").ToList();
           
        //     return Json(list);
        // }

        // public IActionResult GetFirstOldest()
        // {
        //     var oldestAge = persons.Select(person => person.Age).Max();

        //     var oldest = persons.Where(person => person.Age == oldestAge).FirstOrDefault();

        //     return Json(oldest);
        // }

        // public IActionResult GetFullNames()
        // {
        //     var list = persons.Select(person => {
        //         return person.FullName;
        //     }).ToList();

        //     return Json(list);
        // }

        // public IActionResult GetPersonsBirthYearEqual(int yearOfBirth)
        // {
        //     var list = persons.Where(person => person.DateOfBirth.Year == 2000).ToList();

        //     return Json(list);
        // }

        // public IActionResult GetPersonsBirthYearGreater(int yearOfBirth)
        // {
        //     var list = persons.Where(person => person.DateOfBirth.Year > 2000).ToList();

        //     return Json(list);
        // }

        // public IActionResult GetPersonsBirthYearLess(int yearOfBirth)
        // {
        //     var list = persons.Where(person => person.DateOfBirth.Year < 2000).ToList();

        //     return Json(list);
        // }

        // public IActionResult FillterPerson(int yearOfBirth, string type)
        // {
        //     switch(type) {

        //         case "equal": 

        //             return GetPersonsBirthYearEqual(yearOfBirth);

        //         case "greater":

        //             return GetPersonsBirthYearGreater(yearOfBirth);

        //         case "less":

        //             return GetPersonsBirthYearLess(yearOfBirth);

        //         default:
                
        //             return new EmptyResult();
        //     }
        // }

        // public IActionResult ExportListToExcel()
        // {
        //     var builder = new StringBuilder();

        //     builder.AppendLine("Fullname,Gender, Age, Phone number");
            
        //     foreach (var person in persons)
        //     {
        //         builder.AppendLine($"{person.FullName},{person.Gender},{person.Age},{person.PhoneNumber}");
        //     }

        //     return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "persons.csv");
        // }

    }
}