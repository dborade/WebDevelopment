
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeBooking.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        
        // ADD PROPERTIES HERE
        public int TableNumber {get;set;}
        public string TableType { get; set; }
        //public bool isBooked { get; set; }
        public string TimeofBooking { get; set; }//lunch dinner
        public DateTime? DateofBooking { get; set; }
        public string assignedto{get; set;}
        public int AssignRestaurentId { get; set; }
        public Restaurant AssignRestaurent { get; set; }
        public Customer Customer{get; set;}


 public bool IsBooked {
        get {
            return assignedto != null;
        }
    }
    }
}
            