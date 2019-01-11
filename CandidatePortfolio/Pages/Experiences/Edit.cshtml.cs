using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Models;

namespace HelloWorld.Pages.Experiences
{
    public class EditModel : PageModel
    {
        private readonly HelloWorld.Models.AppDbContext _context;

        public EditModel(HelloWorld.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["PersonId"] = new SelectList(_context.Persons, "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Experience).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExperienceExists(Experience.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExperienceExists(int id)
        {
            return _context.Experiences.Any(e => e.Id == id);
        }
    }
}
