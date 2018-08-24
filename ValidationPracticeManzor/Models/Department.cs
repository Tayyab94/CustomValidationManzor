using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationPracticeManzor.Models
{

    public class UniqueNameAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DemoContext demo = new DemoContext();
            string name = value.ToString();

            int count = demo.Departments.Where(x => x.Name == name).ToList().Count();

            if (count != 0)
                return new ValidationResult("This Name has already Exist");

            return ValidationResult.Success;
        }
    }
    public class Department
    {
        public int Id { get; set;  }
        [UniqueName]
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage ="HOD is Required")]
        public string HOD { get; set; }

        
    }
}