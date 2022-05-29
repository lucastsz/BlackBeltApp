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
    public class FaixaGraduacaosController : Controller
    {
        private readonly Contexto _context;

        public FaixaGraduacaosController(Contexto context)
        {
            _context = context;
        }

        // GET: FaixaGraduacaos
        public async Task<IActionResult> Index()
        {
              return _context.FaixaGraduacao != null ? 
                          View(await _context.FaixaGraduacao.ToListAsync()) :
                          Problem("Entity set 'Contexto.FaixaGraduacao'  is null.");
        }

        // GET: FaixaGraduacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FaixaGraduacao == null)
            {
                return NotFound();
            }

            var faixaGraduacao = await _context.FaixaGraduacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faixaGraduacao == null)
            {
                return NotFound();
            }

            return View(faixaGraduacao);
        }

        // GET: FaixaGraduacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FaixaGraduacaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,id_faixa,id_aluno,data_graduacao_faixa,nivel_faixa")] FaixaGraduacao faixaGraduacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faixaGraduacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faixaGraduacao);
        }

        // GET: FaixaGraduacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FaixaGraduacao == null)
            {
                return NotFound();
            }

            var faixaGraduacao = await _context.FaixaGraduacao.FindAsync(id);
            if (faixaGraduacao == null)
            {
                return NotFound();
            }
            return View(faixaGraduacao);
        }

        // POST: FaixaGraduacaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,id_faixa,id_aluno,data_graduacao_faixa,nivel_faixa")] FaixaGraduacao faixaGraduacao)
        {
            if (id != faixaGraduacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faixaGraduacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaixaGraduacaoExists(faixaGraduacao.Id))
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
            return View(faixaGraduacao);
        }

        // GET: FaixaGraduacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FaixaGraduacao == null)
            {
                return NotFound();
            }

            var faixaGraduacao = await _context.FaixaGraduacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faixaGraduacao == null)
            {
                return NotFound();
            }

            return View(faixaGraduacao);
        }

        // POST: FaixaGraduacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FaixaGraduacao == null)
            {
                return Problem("Entity set 'Contexto.FaixaGraduacao'  is null.");
            }
            var faixaGraduacao = await _context.FaixaGraduacao.FindAsync(id);
            if (faixaGraduacao != null)
            {
                _context.FaixaGraduacao.Remove(faixaGraduacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaixaGraduacaoExists(int id)
        {
          return (_context.FaixaGraduacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
