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
    public class UniversityRecordsModel : PageModel
    {
        
        private AppDbContext _context;
        public UniversityRecordsModel(AppDbContext context){
            _context=context;
        }
        public List<Education> UniversityRecords {get;set;}
        public void OnGet()
        {
            UniversityRecords=_context.Educations.Include(x => x.Profile).ToList();
        }
    }
}