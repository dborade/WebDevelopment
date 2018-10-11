using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Models;

namespace HelloWorld.Pages.Skillsets
{
    public class IndexModel : PageModel
    {
        private readonly HelloWorld.Models.AppDbContext _context;

        public IndexModel(HelloWorld.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Skillset> Skillset { get;set; }

        public async Task OnGetAsync()
        {
            Skillset = await _context.Skillsets
                .Include(s => s.Profile).ToListAsync();
        }
    }
}
