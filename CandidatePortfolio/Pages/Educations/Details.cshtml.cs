using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Models;

namespace HelloWorld.Pages.Educations
{
    public class DetailsModel : PageModel
    {
        private readonly HelloWorld.Models.AppDbContext _context;

        public DetailsModel(HelloWorld.Models.AppDbContext context)
        {
            _context = context;
        }

        public Education Education { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Education = await _context.Educations
                .Include(e => e.Profile).FirstOrDefaultAsync(m => m.Id == id);

            if (Education == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
