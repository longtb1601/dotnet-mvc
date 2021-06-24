using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class RookiesController : Controller
    {
        private List<Person> persons = new List<Person>{
            new Person{
                FirstName = "Long",
                LastName = "Bao",
                Gender = "Male",
                DateOfBirth = new DateTime(1994,1,16),
                BirthPlace = "Bac Ninh",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Person{
                FirstName = "Hung",
                LastName = "Ngo Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1991,3,7),
                BirthPlace = "Hai Phong",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Person{
                FirstName = "Van",
                LastName = "Nguyen Cuong",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,3,7),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Person{
                FirstName = "Hao Nhien",
                LastName = "Thang",
                Gender = "Male",
                DateOfBirth = new DateTime(2020,11,13),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Person{
                FirstName = "Lan Phuong",
                LastName = "Nguyen",
                Gender = "Female",
                DateOfBirth = new DateTime(1991,8,8),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            }
        };
        
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