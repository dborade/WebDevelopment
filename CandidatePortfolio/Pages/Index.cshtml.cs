using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Pages
{
    public class IndexModel : PageModel
    {
        private AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
             
            HighSkilled = _context.Skillsets
                                    .Where(x => x.Proficiency == "High Skilled").Count();
            
            Intermediates =  _context.Skillsets
                                    .Where(x => x.Proficiency == "Moderately skilled").Count();

            Beginners = _context.Skillsets
                                    .Where(x => x.Proficiency == "Beginner").Count();
        }   
        public int HighSkilled {get; set;}
        public int Intermediates {get; set;}
        public int Beginners {get; set;}

        }
    }

