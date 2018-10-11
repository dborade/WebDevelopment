using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Models;

namespace HelloWorld.Pages.Skillsets
{
    public class EditModel : PageModel
    {
        private readonly HelloWorld.Models.AppDbContext _context;

        public EditModel(HelloWorld.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Skillset Skillset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Skillset = await _context.Skillsets
                .Include(s => s.Profile).FirstOrDefaultAsync(m => m.Id == id);

            if (Skillset == null)
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

            _context.Attach(Skillset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillsetExists(Skillset.Id))
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

        private bool SkillsetExists(int id)
        {
            return _context.Skillsets.Any(e => e.Id == id);
        }
    }
}
