using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlackBeltApp.Models;

namespace BlackBeltApp.Controllers
{
    public class MestresController : Controller
    {
        private readonly Contexto _context;

        public MestresController(Contexto context)
        {
            _context = context;
        }

        // GET: Mestres
        public async Task<IActionResult> Index()
        {
              return _context.Mestre != null ? 
                          View(await _context.Mestre.ToListAsync()) :
                          Problem("Entity set 'Contexto.Mestre'  is null.");
        }

        // GET: Mestres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Mestre == null)
            {
                return NotFound();
            }

            var mestre = await _context.Mestre
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mestre == null)
            {
                return NotFound();
            }

            return View(mestre);
        }

        // GET: Mestres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mestres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,id_usuario")] Mestre mestre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mestre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mestre);
        }

        // GET: Mestres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Mestre == null)
            {
                return NotFound();
            }

            var mestre = await _context.Mestre.FindAsync(id);
            if (mestre == null)
            {
                return NotFound();
            }
            return View(mestre);
        }

        // POST: Mestres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,id_usuario")] Mestre mestre)
        {
            if (id != mestre.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mestre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MestreExists(mestre.Id))
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
            return View(mestre);
        }

        // GET: Mestres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Mestre == null)
            {
                return NotFound();
            }

            var mestre = await _context.Mestre
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mestre == null)
            {
                return NotFound();
            }

            return View(mestre);
        }

        // POST: Mestres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Mestre == null)
            {
                return Problem("Entity set 'Contexto.Mestre'  is null.");
            }
            var mestre = await _context.Mestre.FindAsync(id);
            if (mestre != null)
            {
                _context.Mestre.Remove(mestre);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MestreExists(int id)
        {
          return (_context.Mestre?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
