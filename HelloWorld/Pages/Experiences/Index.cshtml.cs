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
    public class IndexModel : PageModel
    {
        private readonly HelloWorld.Models.AppDbContext _context;

        public IndexModel(HelloWorld.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Experience> Experience { get;set; }

        public async Task OnGetAsync()
        {
            Experience = await _context.Experiences
                .Include(e => e.Profile).ToListAsync();
        }
    }
}
