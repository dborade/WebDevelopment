
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeBooking.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        
        // ADD PROPERTIES HERE
         public string Name { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PriceRange { get; set; }
        public ICollection<Table> Tables { get; set; }
    }
}
            