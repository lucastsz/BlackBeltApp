﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlackBeltApp.Models;

namespace BlackBeltApp.Controllers
{
    public class AulasController : Controller
    {
        private readonly Contexto _context;

        public AulasController(Contexto context)
        {
            _context = context;
        }

        // GET: Aulas
        public async Task<IActionResult> Index()
        {
              return _context.Aula != null ? 
                          View(await _context.Aula.ToListAsync()) :
                          Problem("Entity set 'Contexto.Aula'  is null.");
        }

        // GET: Aulas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Aula == null)
            {
                return NotFound();
            }

            var aula = await _context.Aula
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aula == null)
            {
                return NotFound();
            }

            return View(aula);
        }

        // GET: Aulas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aulas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,id_mestre,data_aula,anotacao_aula")] Aula aula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aula);
        }

        // GET: Aulas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Aula == null)
            {
                return NotFound();
            }

            var aula = await _context.Aula.FindAsync(id);
            if (aula == null)
            {
                return NotFound();
            }
            return View(aula);
        }

        // POST: Aulas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,id_mestre,data_aula,anotacao_aula")] Aula aula)
        {
            if (id != aula.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AulaExists(aula.Id))
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
            return View(aula);
        }

        // GET: Aulas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Aula == null)
            {
                return NotFound();
            }

            var aula = await _context.Aula
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aula == null)
            {
                return NotFound();
            }

            return View(aula);
        }

        // POST: Aulas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Aula == null)
            {
                return Problem("Entity set 'Contexto.Aula'  is null.");
            }
            var aula = await _context.Aula.FindAsync(id);
            if (aula != null)
            {
                _context.Aula.Remove(aula);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AulaExists(int id)
        {
          return (_context.Aula?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
