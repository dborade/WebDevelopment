using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld.Pages
{
    public class HelpModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your Help page.";
        }
    }
}
