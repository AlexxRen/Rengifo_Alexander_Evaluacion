using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rengifo_Alexander.Data;
using Rengifo_Alexander.Models;

namespace Rengifo_Alexander.Controllers
{
    public class ARengifoController : Controller
    {
        private readonly Rengifo_AlexanderContext _context;

        public ARengifoController(Rengifo_AlexanderContext context)
        {
            _context = context;
        }

        // GET: ARengifo
        public async Task<IActionResult> Index()
        {
            return View(await _context.ARengifo.ToListAsync());
        }

        // GET: ARengifo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aRengifo = await _context.ARengifo
                .FirstOrDefaultAsync(m => m.idEst == id);
            if (aRengifo == null)
            {
                return NotFound();
            }

            return View(aRengifo);
        }

        // GET: ARengifo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ARengifo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idEst,Nombre,Edad,Promedio_General,Beca,FechaIncripcion")] ARengifo aRengifo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aRengifo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aRengifo);
        }

        // GET: ARengifo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aRengifo = await _context.ARengifo.FindAsync(id);
            if (aRengifo == null)
            {
                return NotFound();
            }
            return View(aRengifo);
        }

        // POST: ARengifo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idEst,Nombre,Edad,Promedio_General,Beca,FechaIncripcion")] ARengifo aRengifo)
        {
            if (id != aRengifo.idEst)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aRengifo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ARengifoExists(aRengifo.idEst))
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
            return View(aRengifo);
        }

        // GET: ARengifo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aRengifo = await _context.ARengifo
                .FirstOrDefaultAsync(m => m.idEst == id);
            if (aRengifo == null)
            {
                return NotFound();
            }

            return View(aRengifo);
        }

        // POST: ARengifo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aRengifo = await _context.ARengifo.FindAsync(id);
            if (aRengifo != null)
            {
                _context.ARengifo.Remove(aRengifo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ARengifoExists(int id)
        {
            return _context.ARengifo.Any(e => e.idEst == id);
        }
    }
}
