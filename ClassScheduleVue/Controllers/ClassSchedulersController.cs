using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassSchedule.Models;

namespace ClassSchedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassSchedulersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClassSchedulersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ClassSchedulers
        [HttpGet]
        public IEnumerable<ClassScheduler> GetClassScheduler()
        {
            return _context.ClassScheduler;
        }

        // GET: api/ClassSchedulers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClassScheduler([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var classScheduler = await _context.ClassScheduler.FindAsync(id);

            if (classScheduler == null)
            {
                return NotFound();
            }

            return Ok(classScheduler);
        }

        // PUT: api/ClassSchedulers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassScheduler([FromRoute] int id, [FromBody] ClassScheduler classScheduler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classScheduler.Id)
            {
                return BadRequest();
            }

            _context.Entry(classScheduler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassSchedulerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ClassSchedulers
        [HttpPost]
        public async Task<IActionResult> PostClassScheduler([FromBody] ClassScheduler classScheduler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ClassScheduler.Add(classScheduler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassScheduler", new { id = classScheduler.Id }, classScheduler);
        }

        // DELETE: api/ClassSchedulers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassScheduler([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var classScheduler = await _context.ClassScheduler.FindAsync(id);
            if (classScheduler == null)
            {
                return NotFound();
            }

            _context.ClassScheduler.Remove(classScheduler);
            await _context.SaveChangesAsync();

            return Ok(classScheduler);
        }


        [HttpPut("addClassToSchedule/{id}")]
        public ActionResult<ClassScheduler> addClassToSchedule([FromRoute]int id, [FromBody] ScheduleBuilder schedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var classScheduler = _context.ClassScheduler.Find(id);
            if (classScheduler == null)
            {
                return BadRequest();
            }

            classScheduler.EnrolledStudentName = schedule.Name;
            _context.SaveChanges();
            return Ok(classScheduler);
        }


        [HttpDelete("removeFromSchedule/{id}")]
        public ActionResult<ClassScheduler> removeFromThisClass([FromRoute]int id) {
    
            var classScheduler = _context.ClassScheduler.Find(id);
            if (classScheduler == null) {
                return BadRequest();
            }
       
        classScheduler.EnrolledStudentName = null;
        _context.SaveChanges();
        return Ok(classScheduler);
        }

        private bool ClassSchedulerExists(int id)
        {
            return _context.ClassScheduler.Any(e => e.Id == id);
        }
    }
}