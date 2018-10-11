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
    public class IndexModel : PageModel
    {
        private readonly HelloWorld.Models.AppDbContext _context;

        public IndexModel(HelloWorld.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Education> Education { get;set; }

        public async Task OnGetAsync()
        {
            Education = await _context.Educations
                .Include(e => e.Profile).ToListAsync();
        }
    }
}
