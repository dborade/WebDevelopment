using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoffeeBooking.Models;

namespace CoffeeBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TablesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Tables
        [HttpGet]
        public IEnumerable<Table> GetTable()
        {
            return _context.Table;
        }

        // GET: api/Tables/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTable([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var table = await _context.Table.FindAsync(id);

            if (table == null)
            {
                return NotFound();
            }

            return Ok(table);
        }
        //PUT: using model

        [HttpPut("loan/{id}")]
        public ActionResult<Table> LoanTable([FromRoute]int id, [FromBody] Customer loan) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var table = _context.Table.Find(id);
            if (table == null) {
                return BadRequest();
            }
            //Table.LoanedDate = DateTime.Now;
            table.assignedto = loan.FirstName;
            _context.SaveChanges();
            return Ok(table);
        }
        // PUT: api/Tables/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTable([FromRoute] int id, [FromBody] Table table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != table.Id)
            {
                return BadRequest();
            }

            _context.Entry(table).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableExists(id))
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
//created a new one
        [HttpGet("loan/{id}")]
        public ActionResult<Table[]> GetByRestaurant(int id) 
            {                      
                var results = _context.Table.Where(x => x.AssignRestaurentId == id && x.assignedto == null).ToList();
                return results.ToArray();
            }
        // POST: api/Tables
        [HttpPost]
        public async Task<IActionResult> PostTable([FromBody] Table table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Table.Add(table);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTable", new { id = table.Id }, table);
        }

        // DELETE: api/Tables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTable([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var table = await _context.Table.FindAsync(id);
            if (table == null)
            {
                return NotFound();
            }

            _context.Table.Remove(table);
            await _context.SaveChangesAsync();

            return Ok(table);
        }

        private bool TableExists(int id)
        {
            return _context.Table.Any(e => e.Id == id);
        }
    }
}