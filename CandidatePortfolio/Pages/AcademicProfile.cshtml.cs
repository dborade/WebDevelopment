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
    public class AcademicProfileModel : PageModel
    {
        private AppDbContext _context;
        public AcademicProfileModel(AppDbContext context)
        {
            _context = context;
        }
        public Person Person { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)     
            {
                return NotFound();
            }
           
            Person = _context.Persons
                                .Include(x => x.Educations)         
                                .FirstOrDefault(p => p.Id == id); 
            
            if (Person == null) {
                    return NotFound();
                }
            return Page();

        }
    }
}
