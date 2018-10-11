using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
    public class Skillset
    {
        [Key]
        public int Id { get; set; }



        [RegularExpression(@"^[-@.,/#&$+\w\s]*$", ErrorMessage = "Please Enter valid Programming Language")]
        [StringLength(50, MinimumLength = 3)]
        [CustomValidation(typeof(Skillset), "LanguageDuplicateEntries")]
        [Display(Name = "Programming Language")]
        public string Language { get; set; }

        [RegularExpression(@"[-@.,/#&$+\w\s]*$", ErrorMessage = "Please Enter valid Tools")]
        [StringLength(255, MinimumLength = 3)]
        [Display(Name = "Software/ Database Tools")]
        public string Tools { get; set; }

        [RegularExpression(@"^[-@.,/#&$+\w\s]*$", ErrorMessage = "Please Enter valid Additional Skills")]
        [StringLength(255, MinimumLength = 3)]
        [Display(Name = "Additional Skills")]
        public string Addskills { get; set; }

        [Range(0, 10, ErrorMessage = "Please Enter valid Skill Rating")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please Enter valid Skill Rating")]
        [Display(Name = "Skill Rating")]
        // ADD PROPERTIES HERE
        public int? Rating { get; set; }

        //Relationship
        public int PersonId { get; set; }
        public Person Profile { get; set; }


        //Read only properties
        [NotMapped]
        public String Proficiency
        {
            get
            {
                if (Rating > 8)
                {
                    return "High Skilled";
                }

                else if (Rating > 5)
                {
                    return "Moderately skilled";
                }
                return "Beginner";
            }
        }

    //Custom validation
    public static ValidationResult LanguageDuplicateEntries(string Name, ValidationContext context) 
        {
        if (string.IsNullOrWhiteSpace(Name)) {
            return ValidationResult.Success;
        }
        var instance = context.ObjectInstance as Skillset;
        if (instance == null) {
            return ValidationResult.Success;
        }

        
        var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
        //Person person = dbContext.Persons.Include(x => x.Skillsets).FirstOrDefault();
        

        
        int duplicateCount = dbContext.Skillsets
                                  .Count(x => x.Id != instance.Id && x.Language == Name && x.PersonId == instance.PersonId);
        if (duplicateCount > 0) {
            return new ValidationResult($"Record for {Name} already exists");
        }
        return ValidationResult.Success;
    }


        

    }
}
