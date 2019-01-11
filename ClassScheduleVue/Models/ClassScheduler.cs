
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassSchedule.Models
{
    public class ClassScheduler
    {
        [Key]
        public int Id { get; set; }
        
        // ADD PROPERTIES HERE
        public string ClassCode {get;set;}
        public string ClassName {get;set;}

        public string Professor {get;set;}

        public string TotalEnrollment {get;set;}

        public string EnrolledStudentName {get;set;}

        /*/public string AvailableSeats {
            get{
                return TotalEnrollment;
            }
        }*/
        public Boolean IsClassAdded{
            get{
                if(EnrolledStudentName !=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}}
            