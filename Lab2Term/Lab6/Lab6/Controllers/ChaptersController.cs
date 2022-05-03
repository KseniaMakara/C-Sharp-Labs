using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab6.Models;
using Microsoft.AspNetCore.Authorization;

namespace Lab5p.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaptersController : ControllerBase
    {
        private readonly DCLAB6LAB6LAB5PMDFContext _context;
        public ChaptersController(DCLAB6LAB6LAB5PMDFContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chapters>>> GetPages()
        {
            return await _context.Chapters.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Chapters>> GetPages(int id)
        {
            var Pages = await _context.Chapters.FindAsync(id);

            if (Pages == null)
            {
                return NotFound();
            }

            return Pages;
        }

        [Authorize(Roles = "Admin")]

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPages(int id, Chapters Pages)
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

        [Authorize(Roles = "Admin")]

        [HttpPost]
        public async Task<ActionResult<Chapters>> PostPages(Chapters Pages)
        {
            _context.Chapters.Add(Pages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPages", new { id = Pages.Id }, Pages);
        }

        [Authorize(Roles = "Admin")]

        [HttpDelete("{id}")]
        public async Task<ActionResult<Chapters>> DeletePages(int id)
        {
            var Pages = await _context.Chapters.FindAsync(id);
            if (Pages == null)
            {
                return NotFound();
            }

            _context.Chapters.Remove(Pages);
            await _context.SaveChangesAsync();

            return Pages;
        }

        private bool PagesExists(int id)
        {
            return _context.Chapters.Any(e => e.Id == id);
        }
    }
}
