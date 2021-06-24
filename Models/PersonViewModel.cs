using System;

namespace MVC.Models
{
    public class Person
    {
        protected string _firstName;
        public string FirstName { 
            get
            {
                return _firstName;
            }
            set 
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }

        public int Age { 
            get
            { 
                return CalculateAge();
            }
        }
        private int CalculateAge() {
            TimeSpan ts = DateTime.Now - DateOfBirth;

            DateTime age = DateTime.MinValue.AddDays(ts.Days);

            return age.Year - 1; 
        }
        public bool IsGraduated { get; set; }
        public string FullName { 

            get {
                return $"{LastName} {FirstName}";
            }
            
        }
    }
}
