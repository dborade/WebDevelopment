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
    public class SearchStudentModel : PageModel
    {
        private AppDbContext _context;


        public SearchStudentModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            SearchCompleted = false;
        }


        [BindProperty]
        public string SearchStudent { get; set; }

        public bool SearchCompleted { get; set; }

        public ICollection<Education> SearchResults { get; set; }


        public void OnPost()
        {
            // PERFORM SEARCH
            if (string.IsNullOrWhiteSpace(SearchStudent))
            {
                // EXIT EARLY IF THERE IS NO SEARCH TERM PROVIDED
                return;
            }

           
            SearchResults = _context.Educations
                                        .Include(x => x.Profile)
                                        .Where(x => x.UniversityName.ToLower().Contains(SearchStudent.ToLower()))
                                        .ToList();

            SearchCompleted = true;
        }
    }
}