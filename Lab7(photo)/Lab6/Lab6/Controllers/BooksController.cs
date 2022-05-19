using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab6.Models;
using Microsoft.AspNetCore.Authorization;

namespace Lab6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly DCLAB6LAB6LAB5PMDFContext _context;

        public BooksController(DCLAB6LAB6LAB5PMDFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Books>>> GetManga(int? minimalpages, string name)
        {
            var mangas = _context.Books.Where(jojo => true);
            if (minimalpages.HasValue)
            {
               mangas = mangas.Where(jojo => jojo.Pages >= minimalpages.Value);
            }

            if (name != null)
            {
               mangas = mangas.Where(jojo => jojo.Title.ToLower().Contains(name.ToLower()));
            }

            return await mangas.Include(jojo => jojo.Chapters).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Books>> GetManga(int id)
        {
            var mangas = await _context.Books.FindAsync(id);

            if (mangas == null)
            {
                return NotFound();
            }

            return mangas;
        }

        [Authorize(Roles = "Admin, Users")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManga(int id, Books mangas)
        {
            if (id != mangas.Id)
            {
                return BadRequest();
            }

            _context.Entry(mangas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MangaExists(id))
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

        [Authorize(Roles = "Admin, Users")]

        [HttpPost]
        public async Task<ActionResult<Books>> PostManga(Books mangas)
        {
            _context.Books.Add(mangas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetManga", new { id = mangas.Id }, mangas);
        }

        [Authorize(Roles = "Admin, Users")]

        [HttpDelete("{id}")]
        public async Task<ActionResult<Books>> DeleteManga(int id)
        {
            var mangas = await _context.Books.FindAsync(id);
            if (mangas == null)
            {
                return NotFound();
            }

            _context.Books.Remove(mangas);
            await _context.SaveChangesAsync();

            return mangas;
        }

        private bool MangaExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
