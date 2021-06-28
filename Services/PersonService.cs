using System;
using System.Collections.Generic;
using System.Linq;
using MVC.Models;

namespace MVC.Services
{
    public class PersonService : IPersonService
    {
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

        public List<Person> All => throw new NotImplementedException();

        public List<Person> GetAll()
        {
            return persons;
        }

        public Person GetOne(int id)
        {
            return persons.Where(person => person.Id == id).FirstOrDefault();
        }

        public void Create(Person model)
        {
           int id = 0;

            if(!persons.Any()) {

                id = 1;

            } else {

                var personMaxId = persons.OrderByDescending(person => person.Id).First();

                id = personMaxId.Id++;

            }

            model.Id = id;

            persons.Add(model);
        }

        public void Delete(int id)
        {
            var model = persons.FirstOrDefault(person => person.Id == id);

            var list = persons.Where(m => m.Id != model.Id).ToList();

            persons = list; 
        }

        public void Edit(Person model)
        {
            var list = persons.Where(person => person.Id != model.Id).ToList();

            list.Insert(0, model);

            persons = list;
        }
    }
}