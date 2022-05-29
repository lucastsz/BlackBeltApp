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
    public class FaixasController : Controller
    {
        private readonly Contexto _context;

        public FaixasController(Contexto context)
        {
            _context = context;
        }

        // GET: Faixas
        public async Task<IActionResult> Index()
        {
              return _context.Faixa != null ? 
                          View(await _context.Faixa.ToListAsync()) :
                          Problem("Entity set 'Contexto.Faixa'  is null.");
        }

        // GET: Faixas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Faixa == null)
            {
                return NotFound();
            }

            var faixa = await _context.Faixa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faixa == null)
            {
                return NotFound();
            }

            return View(faixa);
        }

        // GET: Faixas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Faixas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nivel_max_faixa,nivel_min_faixa,nivel_aula_faixa")] Faixa faixa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faixa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faixa);
        }

        // GET: Faixas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Faixa == null)
            {
                return NotFound();
            }

            var faixa = await _context.Faixa.FindAsync(id);
            if (faixa == null)
            {
                return NotFound();
            }
            return View(faixa);
        }

        // POST: Faixas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nivel_max_faixa,nivel_min_faixa,nivel_aula_faixa")] Faixa faixa)
        {
            if (id != faixa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faixa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaixaExists(faixa.Id))
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
            return View(faixa);
        }

        // GET: Faixas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Faixa == null)
            {
                return NotFound();
            }

            var faixa = await _context.Faixa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faixa == null)
            {
                return NotFound();
            }

            return View(faixa);
        }

        // POST: Faixas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Faixa == null)
            {
                return Problem("Entity set 'Contexto.Faixa'  is null.");
            }
            var faixa = await _context.Faixa.FindAsync(id);
            if (faixa != null)
            {
                _context.Faixa.Remove(faixa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaixaExists(int id)
        {
          return (_context.Faixa?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
