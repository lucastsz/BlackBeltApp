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
    public class FinalCampeonatosController : Controller
    {
        private readonly Contexto _context;

        public FinalCampeonatosController(Contexto context)
        {
            _context = context;
        }

        // GET: FinalCampeonatos
        public async Task<IActionResult> Index()
        {
              return _context.FinalCampeonato != null ? 
                          View(await _context.FinalCampeonato.ToListAsync()) :
                          Problem("Entity set 'Contexto.FinalCampeonato'  is null.");
        }

        // GET: FinalCampeonatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FinalCampeonato == null)
            {
                return NotFound();
            }

            var finalCampeonato = await _context.FinalCampeonato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (finalCampeonato == null)
            {
                return NotFound();
            }

            return View(finalCampeonato);
        }

        // GET: FinalCampeonatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FinalCampeonatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,id_aluno1,id_aluno2")] FinalCampeonato finalCampeonato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(finalCampeonato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(finalCampeonato);
        }

        // GET: FinalCampeonatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FinalCampeonato == null)
            {
                return NotFound();
            }

            var finalCampeonato = await _context.FinalCampeonato.FindAsync(id);
            if (finalCampeonato == null)
            {
                return NotFound();
            }
            return View(finalCampeonato);
        }

        // POST: FinalCampeonatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,id_aluno1,id_aluno2")] FinalCampeonato finalCampeonato)
        {
            if (id != finalCampeonato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(finalCampeonato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinalCampeonatoExists(finalCampeonato.Id))
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
            return View(finalCampeonato);
        }

        // GET: FinalCampeonatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FinalCampeonato == null)
            {
                return NotFound();
            }

            var finalCampeonato = await _context.FinalCampeonato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (finalCampeonato == null)
            {
                return NotFound();
            }

            return View(finalCampeonato);
        }

        // POST: FinalCampeonatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FinalCampeonato == null)
            {
                return Problem("Entity set 'Contexto.FinalCampeonato'  is null.");
            }
            var finalCampeonato = await _context.FinalCampeonato.FindAsync(id);
            if (finalCampeonato != null)
            {
                _context.FinalCampeonato.Remove(finalCampeonato);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinalCampeonatoExists(int id)
        {
          return (_context.FinalCampeonato?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
