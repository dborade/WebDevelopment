using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
    public class CreateNewDegreeForm
    {
        [Key]
        public int Id { get; set; }

        // ADD PROPERTIES HERE

        [Display(Name = "Person")]
        [Required(ErrorMessage = "Please select a person")]
        [CustomValidation(typeof(CreateNewDegreeForm), "ValidatePerson")]
        public int? PersonId { get; set; }


        /* [Display(Name = "University Name")]
        [Required(ErrorMessage = "Please select an university name")]
        [CustomValidation(typeof(CreateNewDegreeForm), "ValidateUniversityName")]
        public int? UniversityId { get; set; } */

        public String DegreeName {get; set;}
        
        public double? GPA { get; set; }

        public static ValidationResult ValidatePerson(int? PersonId, ValidationContext context)
        {
            if (PersonId == null)
            {
                return ValidationResult.Success;
            }
            var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
            var PersonRecord = dbContext.Persons
                                         .Include(x => x.Educations)
                                         .FirstOrDefault(x => x.Id == PersonId.Value);
            if (PersonRecord == null)
            {
                return new ValidationResult("Please select a valid person");
            }
           
            return ValidationResult.Success;
        }

        public static ValidationResult ValidateUniversityName(int? UniversityId, ValidationContext context)
        {
            if (UniversityId == null)
            {
                return ValidationResult.Success;
            }
            var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
            var agent = dbContext.Educations.FirstOrDefault(x => x.Id == UniversityId.Value);
            if (agent == null)
            {
                return new ValidationResult("Please select a valid University");
            }
            return ValidationResult.Success;
        }
    }
}
   
