
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeBooking.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        // ADD PROPERTIES HERE
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Phone]
        public string ContactNo { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int TableId{get;set;}
        public Table Table{get; set;}
    }
}
            