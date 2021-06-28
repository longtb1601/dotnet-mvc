using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Person
    {
        protected string _firstName;
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
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

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [EmailAddress]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Invalid email address")]
        public string Email {get; set; }
     
        [StringLength(11, MinimumLength = 9, ErrorMessage = "Phone number have at least 9 digits.")] 
        [RegularExpression(@"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$", ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone Number")]
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
