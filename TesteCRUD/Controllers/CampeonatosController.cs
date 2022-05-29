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
    public class CampeonatosController : Controller
    {
        private readonly Contexto _context;

        public CampeonatosController(Contexto context)
        {
            _context = context;
        }

        // GET: Campeonatos
        public async Task<IActionResult> Index()
        {
              return _context.Campeonato != null ? 
                          View(await _context.Campeonato.ToListAsync()) :
                          Problem("Entity set 'Contexto.Campeonato'  is null.");
        }

        // GET: Campeonatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Campeonato == null)
            {
                return NotFound();
            }

            var campeonato = await _context.Campeonato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campeonato == null)
            {
                return NotFound();
            }

            return View(campeonato);
        }

        // GET: Campeonatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Campeonatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,id_quarta,id_semi,id_final,id_vencedor")] Campeonato campeonato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campeonato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campeonato);
        }

        // GET: Campeonatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Campeonato == null)
            {
                return NotFound();
            }

            var campeonato = await _context.Campeonato.FindAsync(id);
            if (campeonato == null)
            {
                return NotFound();
            }
            return View(campeonato);
        }

        // POST: Campeonatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,id_quarta,id_semi,id_final,id_vencedor")] Campeonato campeonato)
        {
            if (id != campeonato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campeonato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampeonatoExists(campeonato.Id))
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
            return View(campeonato);
        }

        // GET: Campeonatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Campeonato == null)
            {
                return NotFound();
            }

            var campeonato = await _context.Campeonato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campeonato == null)
            {
                return NotFound();
            }

            return View(campeonato);
        }

        // POST: Campeonatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Campeonato == null)
            {
                return Problem("Entity set 'Contexto.Campeonato'  is null.");
            }
            var campeonato = await _context.Campeonato.FindAsync(id);
            if (campeonato != null)
            {
                _context.Campeonato.Remove(campeonato);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampeonatoExists(int id)
        {
          return (_context.Campeonato?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
