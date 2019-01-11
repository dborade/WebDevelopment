using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorld.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Please Enter valid University name")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "University Name")]
        public string UniversityName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z. ]+$", ErrorMessage = "Please Enter valid College name")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "College Name")]
        public string CollegeName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Please Enter valid Degree name")]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Degree Name")]
        public string DegreeName { get; set; }

        [CustomValidation(typeof(Education), "InvalidGPA")]
        [Display(Name = "GPA")]
        public double? GPA { get; set; }


        [StringLength(255, MinimumLength = 2)]
        [Display(Name = "Relevant Coursework")]
        public string RelevantCoursework { get; set; }

        [Display(Name = "Certifications")]
        public string Certifications { get; set; }

        //Relationship
        public int PersonId { get; set; }
        public Person Profile { get; set; }

        //Custom Validation
        public static ValidationResult InvalidGPA(double? GPA, ValidationContext context)
        {
            if (GPA == null)
            {
                return ValidationResult.Success;
            }
            if (GPA > 4.00)
            {
                return new ValidationResult("GPA value cannot exceed 4.00");

            }
            return ValidationResult.Success;
        }


        //Read only property
        [NotMapped]     
        public String DegreeType{
           get {       
                if(DegreeName!= null && DegreeName.Contains("MS")||DegreeName.Contains("MBA")||DegreeName.Contains("MTech")||DegreeName.Contains("MA")) 
                {
                    return "Graduate Degree";
                }

                else if(DegreeName.Contains("Bachelor")||DegreeName.Contains("BS")||DegreeName.Contains("BE")||DegreeName.Contains("BTech"))
                {
                    return "Undergraduate Degree";
                }
               return "Unknown"; 
           
           }    
        }       
        }

    }

