using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab5p.Models;

namespace Lab5p.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly DCLab5pLAB5PMDFContext _context;

        public PagesController(DCLab5pLAB5PMDFContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pages>>> GetPages()
        {
            return await _context.Pages.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pages>> GetPages(int id)
        {
            var Pages = await _context.Pages.FindAsync(id);

            if (Pages == null)
            {
                return NotFound();
            }

            return Pages;
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPages(int id, Pages Pages)
        {
            if (id != Pages.Id)
            {
                return BadRequest();
            }

            _context.Entry(Pages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagesExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Pages>> PostPages(Pages Pages)
        {
            _context.Pages.Add(Pages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPages", new { id = Pages.Id }, Pages);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Pages>> DeletePages(int id)
        {
            var Pages = await _context.Pages.FindAsync(id);
            if (Pages == null)
            {
                return NotFound();
            }

            _context.Pages.Remove(Pages);
            await _context.SaveChangesAsync();

            return Pages;
        }

        private bool PagesExists(int id)
        {
            return _context.Pages.Any(e => e.Id == id);
        }
    }
}
