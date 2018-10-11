using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Models;

namespace HelloWorld.Pages.Experiences
{
    public class DetailsModel : PageModel
    {
        private readonly HelloWorld.Models.AppDbContext _context;

        public DetailsModel(HelloWorld.Models.AppDbContext context)
        {
            _context = context;
        }

        public Experience Experience { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Experience = await _context.Experiences
                .Include(e => e.Profile).FirstOrDefaultAsync(m => m.Id == id);

            if (Experience == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
