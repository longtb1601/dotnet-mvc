using System.Collections.Generic;
using MVC.Models;

namespace MVC.Services {
    public interface IPersonService
    {
        Person GetOne(int id);

        List<Person> GetAll();

        void Create(Person model);

        void Edit(Person model);

        void Delete(int id);
    }
}