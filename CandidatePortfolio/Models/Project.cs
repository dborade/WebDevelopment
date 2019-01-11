using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Project name")]       
        [Display(Name="Name of the Project")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Project Skills")] 
        [Display(Name="Associated with Skills")]
        public string Skills { get; set; }
        
        [Display(Name="Project Info")]
        public string Info { get; set; }

        //Relationship
        public int PersonId { get; set; }
        public Person Profile { get; set; }

    }
}
