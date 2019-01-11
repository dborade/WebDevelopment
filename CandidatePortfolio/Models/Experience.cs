using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorld.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Please Enter valid Company name")]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z- ]+$", ErrorMessage = "Please Enter valid Designation")]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Please Enter valid Project information")]
        [Display(Name = "Projects")]
        public string Project { get; set; }


        [Display(Name = "Tenure")]
        public string Tenure { get; set; }

        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Please Enter valid City")]
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "City")]
        public string City { get; set; }

        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Please Enter valid Country")]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Experience Details")]
        public string ExperienceDetails { get; set;}

        //Relationship
        public int PersonId { get; set; }
        public Person Profile { get; set; }

        //Read only properties
        public string DisplayName {
            get { return $"{City}, {Country}"; }
        }

       

    }
}
