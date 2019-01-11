
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloWorld.Pages
{
    public class CreateNewDegreeModel : PageModel
    {

        private readonly AppDbContext _context;
        public CreateNewDegreeModel(AppDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public CreateNewDegreeForm CreateNewDegreeForm { get; set; }
        public void OnGet()
        {
            PopulateSelectLists();
        }


        private void PopulateSelectLists()
        {
            // GET Univeristy
           /*  var Univeristies = _context.Educations
                                 .ToList();

            // NOTE WE SET THE ViewData property with the same name as the 
            // property name in our model that will hold the selected value
            ViewData["Id"] = new SelectList(Univeristies, "Id", "Name"); */

            //Get Person
            var Persons = _context.Persons
                                 .ToList();

            // NOTE WE SET THE ViewData property with the same name as the 
            // property name in our model that will hold the selected value
            ViewData["PersonId"] = new SelectList(Persons, "Id", "Name");
        }


        public IActionResult OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                PopulateSelectLists();
                return Page();
            }
           

            var NewDegree = new Education();
            NewDegree.PersonId= CreateNewDegreeForm.PersonId.Value;
            NewDegree.DegreeName = CreateNewDegreeForm.DegreeName;
            NewDegree.GPA = CreateNewDegreeForm.GPA;

            

            _context.Educations.Add(NewDegree);
            _context.SaveChanges();
            return RedirectToPage("/Educations/Details" ,  new { Id = NewDegree.Id });
    }
}
}