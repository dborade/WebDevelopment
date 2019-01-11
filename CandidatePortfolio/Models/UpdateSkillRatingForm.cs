
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
    public class UpdateSkillRatingForm
    {

        public UpdateSkillRatingForm()
        {
            
        }
        [Key]
        public int Id { get; set; }
        
        // ADD PROPERTIES HERE
        [RegularExpression(@"^[-@./#&$+\w\s]*$", ErrorMessage = "Please Enter valid Skills")]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name="Skills")]
        public string Skill { get; set; }
        
        [Range(0, 10, ErrorMessage = "Please Enter valid Skill Rating")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please Enter valid Skill ratings")]
        [Display(Name="Skill Rating")]
        public int? Rating {get;set;}
        public int? SkillId { get; set; }

        //Relationship
        public int PersonId { get; set; }
        public Person Person { get; set; }
        

          }
}
            