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
    public class QuartasCampeonatosController : Controller
    {
        private readonly Contexto _context;

        public QuartasCampeonatosController(Contexto context)
        {
            _context = context;
        }

        // GET: QuartasCampeonatos
        public async Task<IActionResult> Index()
        {
              return _context.QuartasCampeonato != null ? 
                          View(await _context.QuartasCampeonato.ToListAsync()) :
                          Problem("Entity set 'Contexto.QuartasCampeonato'  is null.");
        }

        // GET: QuartasCampeonatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.QuartasCampeonato == null)
            {
                return NotFound();
            }

            var quartasCampeonato = await _context.QuartasCampeonato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quartasCampeonato == null)
            {
                return NotFound();
            }

            return View(quartasCampeonato);
        }

        // GET: QuartasCampeonatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuartasCampeonatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,id_aluno1,id_aluno2,id_aluno3,id_aluno4,id_aluno5,id_aluno6,id_aluno7,id_aluno8")] QuartasCampeonato quartasCampeonato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quartasCampeonato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quartasCampeonato);
        }

        // GET: QuartasCampeonatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.QuartasCampeonato == null)
            {
                return NotFound();
            }

            var quartasCampeonato = await _context.QuartasCampeonato.FindAsync(id);
            if (quartasCampeonato == null)
            {
                return NotFound();
            }
            return View(quartasCampeonato);
        }

        // POST: QuartasCampeonatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,id_aluno1,id_aluno2,id_aluno3,id_aluno4,id_aluno5,id_aluno6,id_aluno7,id_aluno8")] QuartasCampeonato quartasCampeonato)
        {
            if (id != quartasCampeonato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quartasCampeonato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuartasCampeonatoExists(quartasCampeonato.Id))
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
            return View(quartasCampeonato);
        }

        // GET: QuartasCampeonatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.QuartasCampeonato == null)
            {
                return NotFound();
            }

            var quartasCampeonato = await _context.QuartasCampeonato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quartasCampeonato == null)
            {
                return NotFound();
            }

            return View(quartasCampeonato);
        }

        // POST: QuartasCampeonatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.QuartasCampeonato == null)
            {
                return Problem("Entity set 'Contexto.QuartasCampeonato'  is null.");
            }
            var quartasCampeonato = await _context.QuartasCampeonato.FindAsync(id);
            if (quartasCampeonato != null)
            {
                _context.QuartasCampeonato.Remove(quartasCampeonato);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuartasCampeonatoExists(int id)
        {
          return (_context.QuartasCampeonato?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
