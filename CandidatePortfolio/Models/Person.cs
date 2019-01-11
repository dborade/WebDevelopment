using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorld.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Please Enter valid name")]
        [CustomValidation(typeof(Person), "PersonDuplicateEntries")]
        [StringLength(40, MinimumLength = 3)]
        [DisplayName("Full Name")]
        public string Name { get; set; }

        [CustomValidation(typeof(Person), "DateOFBirthFuture")]
        [DataType(DataType.Date),DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}",ApplyFormatInEditMode = true )]
        [Display(Name="Date of Birth")]
        public DateTime DOB { get; set; }


        [EmailAddress(ErrorMessage = "Please provide a valid email address")]
        [Required(ErrorMessage = "Email is required")]
        [Display(Name="E-mail")]
        public string Email { get; set; }


        [Phone(ErrorMessage = "Please provide a valid US phone number")]    
        [Display(Name="Phone Number")]
        public string PhoneNumber { get; set; }


        [Url(ErrorMessage = "Please provide a valid url")]
        [Display(Name="Website")]
        public string Website { get; set; }

        //Relationship
        public ICollection<Education> Educations { get; set; }

        public ICollection<Experience> Experiences{get; set;}

        public ICollection<Project> Projects {get; set;}

        public ICollection<Skillset> Skillsets{get; set;}


        //Custom validation
        public static ValidationResult PersonDuplicateEntries(string Name, ValidationContext context) 
        {
        if (string.IsNullOrWhiteSpace(Name)) {
            return ValidationResult.Success;
        }
        var instance = context.ObjectInstance as Person;
        if (instance == null) {
            return ValidationResult.Success;
        }
       
        var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
        int duplicateCount = dbContext.Persons
                                  .Count(x => x.Id != instance.Id && x.Name == Name);
        if (duplicateCount > 0) {
            return new ValidationResult($"Record for {Name} already exists");
        }
        return ValidationResult.Success;
    }

     //Custom validation
     public static ValidationResult DateOFBirthFuture(DateTime? DateOfBirth, ValidationContext context) 
    {
        if (DateOfBirth == null) {
        return ValidationResult.Success;
    }
        if (DateOfBirth > DateTime.Today) {
        return new ValidationResult("Birth date cannot be a future date.");
       
    }
        return ValidationResult.Success;
    }


    
    public int CalculateAge(DateTime dateOfBirth)   
        { 
        int age = 0;
        age = DateTime.Now.Year - dateOfBirth.Year;
        if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear) 
        age = age - 1;

            return age;
        } 

    //Read only properties      
    [NotMapped] 
    public int age
        {
            get
            {
                return CalculateAge(DOB);
            }
        }
    
    }
}
