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
    public class MangaController : ControllerBase
    {
        private readonly DCLab5pLAB5PMDFContext _context;

        public MangaController(DCLab5pLAB5PMDFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manga>>> GetManga(int? minimalpages, string name)
        {
            var mangas = _context.Manga.Where(jojo => true);
            if (minimalpages.HasValue)
            {
               mangas = mangas.Where(jojo => jojo.Pages >= minimalpages.Value);
            }

            if (name != null)
            {
               mangas = mangas.Where(jojo => jojo.Name.ToLower().Contains(name.ToLower()));
            }

            return await mangas.Include(jojo => jojo.Pages).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Manga>> GetManga(int id)
        {
            var mangas = await _context.Manga.FindAsync(id);

            if (mangas == null)
            {
                return NotFound();
            }

            return mangas;
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManga(int id, Manga mangas)
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

        [HttpPost]
        public async Task<ActionResult<Manga>> PostManga(Manga mangas)
        {
            _context.Manga.Add(mangas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetManga", new { id = mangas.Id }, mangas);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Manga>> DeleteManga(int id)
        {
            var mangas = await _context.Manga.FindAsync(id);
            if (mangas == null)
            {
                return NotFound();
            }

            _context.Manga.Remove(mangas);
            await _context.SaveChangesAsync();

            return mangas;
        }

        private bool MangaExists(int id)
        {
            return _context.Manga.Any(e => e.Id == id);
        }
    }
}
