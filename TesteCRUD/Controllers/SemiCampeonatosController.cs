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
    public class SemiCampeonatosController : Controller
    {
        private readonly Contexto _context;

        public SemiCampeonatosController(Contexto context)
        {
            _context = context;
        }

        // GET: SemiCampeonatos
        public async Task<IActionResult> Index()
        {
              return _context.SemiCampeonato != null ? 
                          View(await _context.SemiCampeonato.ToListAsync()) :
                          Problem("Entity set 'Contexto.SemiCampeonato'  is null.");
        }

        // GET: SemiCampeonatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SemiCampeonato == null)
            {
                return NotFound();
            }

            var semiCampeonato = await _context.SemiCampeonato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (semiCampeonato == null)
            {
                return NotFound();
            }

            return View(semiCampeonato);
        }

        // GET: SemiCampeonatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SemiCampeonatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,id_aluno1,id_aluno2,id_aluno3,id_aluno4")] SemiCampeonato semiCampeonato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(semiCampeonato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(semiCampeonato);
        }

        // GET: SemiCampeonatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SemiCampeonato == null)
            {
                return NotFound();
            }

            var semiCampeonato = await _context.SemiCampeonato.FindAsync(id);
            if (semiCampeonato == null)
            {
                return NotFound();
            }
            return View(semiCampeonato);
        }

        // POST: SemiCampeonatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,id_aluno1,id_aluno2,id_aluno3,id_aluno4")] SemiCampeonato semiCampeonato)
        {
            if (id != semiCampeonato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(semiCampeonato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SemiCampeonatoExists(semiCampeonato.Id))
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
            return View(semiCampeonato);
        }

        // GET: SemiCampeonatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SemiCampeonato == null)
            {
                return NotFound();
            }

            var semiCampeonato = await _context.SemiCampeonato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (semiCampeonato == null)
            {
                return NotFound();
            }

            return View(semiCampeonato);
        }

        // POST: SemiCampeonatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SemiCampeonato == null)
            {
                return Problem("Entity set 'Contexto.SemiCampeonato'  is null.");
            }
            var semiCampeonato = await _context.SemiCampeonato.FindAsync(id);
            if (semiCampeonato != null)
            {
                _context.SemiCampeonato.Remove(semiCampeonato);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SemiCampeonatoExists(int id)
        {
          return (_context.SemiCampeonato?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
