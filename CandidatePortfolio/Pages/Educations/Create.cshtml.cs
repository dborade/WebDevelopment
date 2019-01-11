using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HelloWorld.Models;

namespace HelloWorld.Pages.Educations
{
    public class CreateModel : PageModel
    {
        private readonly HelloWorld.Models.AppDbContext _context;

        public CreateModel(HelloWorld.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PersonId"] = new SelectList(_context.Persons, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Education Education { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Educations.Add(Education);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}