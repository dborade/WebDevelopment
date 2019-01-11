using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using HelloWorld.Models;

namespace HelloWorld.Pages
{
    public class UpdateSkillRatingModel : PageModel
    {

        private readonly AppDbContext _context;
        public UpdateSkillRatingModel(AppDbContext context)
        {
            _context = context;
        }
        

        [BindProperty]
        public UpdateSkillRatingForm UpdateSkillRatingForm { get; set; }

        public Person Person { get; set; }
        public IActionResult OnGet(int? id)
        {

            if (id == null) {
                return NotFound();
            }

           // Person = _context.Persons                           
                            //.Find(id);

            Person =  _context.Persons
                        .Include(e=> e.Skillsets)
                        .FirstOrDefault(e => e.Id == id);

            /* foreach (var skillset in Person.Skillsets)
            {
                await ((IQueryable)setMethod.MakeGenericMethod(navigation.GetTargetType().ClrType)
                    .Invoke(_context, null))
                    .OfType<object>()
                    .LoadAsync();
            }  */
            

            if (Person == null) {
                return NotFound();
            }

            UpdateSkillRatingForm = new UpdateSkillRatingForm();
            UpdateSkillRatingForm.PersonId = Person.Id;
            //ViewData["SkillId"] = new SelectList(Person.Skillsets, "Id", "Language");
            
            return Page();
        }


            public IActionResult OnPost() 
            {
            Console.WriteLine("****UpdateSkillRatingForm.PersonId"+UpdateSkillRatingForm.Person);
            Person = _context.Persons.Include(e=> e.Skillsets)
                        .FirstOrDefault(e => e.Id == UpdateSkillRatingForm.PersonId);
            
            if (!ModelState.IsValid) {
                 return Page();
            }
            
            
            foreach(var Skillset in Person.Skillsets)
            {
               
            if(Skillset.Language==UpdateSkillRatingForm.Skill || Skillset.Tools==UpdateSkillRatingForm.Skill || Skillset.Addskills==UpdateSkillRatingForm.Skill )
            {
            Skillset.Rating = UpdateSkillRatingForm.Rating;
            _context.SaveChanges();
            return RedirectToPage("/UpdateSkillRating", new  { id = Skillset.Id });
            }
            
            }
            return NotFound();
                      
            }
    }
}
