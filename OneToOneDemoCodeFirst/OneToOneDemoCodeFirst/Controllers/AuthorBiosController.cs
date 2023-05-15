using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OneToOneDemoCodeFirst.Models;

namespace OneToOneDemoCodeFirst.Controllers
{
    public class AuthorBiosController : Controller
    {
        private readonly AuthorContext _context;

        public AuthorBiosController(AuthorContext context)
        {
            _context = context;
        }

        // GET: AuthorBios
        public async Task<IActionResult> Index()
        {
            var authorContext = _context.AuthorBios.Include(a => a.Author);
            return View(await authorContext.ToListAsync());
        }

        // GET: AuthorBios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AuthorBios == null)
            {
                return NotFound();
            }

            var authorBio = await _context.AuthorBios
                .Include(a => a.Author)
                .FirstOrDefaultAsync(m => m.AuthorBioId == id);
            if (authorBio == null)
            {
                return NotFound();
            }

            return View(authorBio);
        }

        // GET: AuthorBios/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId");
            return View();
        }

        // POST: AuthorBios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuthorBioId,Biography,DateOfBirth,PlaceofBirth,Nationality,AuthorId")] AuthorBio authorBio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authorBio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId", authorBio.AuthorId);
            return View(authorBio);
        }

        // GET: AuthorBios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AuthorBios == null)
            {
                return NotFound();
            }

            var authorBio = await _context.AuthorBios.FindAsync(id);
            if (authorBio == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId", authorBio.AuthorId);
            return View(authorBio);
        }

        // POST: AuthorBios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuthorBioId,Biography,DateOfBirth,PlaceofBirth,Nationality,AuthorId")] AuthorBio authorBio)
        {
            if (id != authorBio.AuthorBioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(authorBio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorBioExists(authorBio.AuthorBioId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId", authorBio.AuthorId);
            return View(authorBio);
        }

        // GET: AuthorBios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AuthorBios == null)
            {
                return NotFound();
            }

            var authorBio = await _context.AuthorBios
                .Include(a => a.Author)
                .FirstOrDefaultAsync(m => m.AuthorBioId == id);
            if (authorBio == null)
            {
                return NotFound();
            }

            return View(authorBio);
        }

        // POST: AuthorBios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AuthorBios == null)
            {
                return Problem("Entity set 'AuthorContext.AuthorBios'  is null.");
            }
            var authorBio = await _context.AuthorBios.FindAsync(id);
            if (authorBio != null)
            {
                _context.AuthorBios.Remove(authorBio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthorBioExists(int id)
        {
          return (_context.AuthorBios?.Any(e => e.AuthorBioId == id)).GetValueOrDefault();
        }
    }
}
