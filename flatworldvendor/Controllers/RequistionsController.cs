using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using flatworldvendor.Data;
using flatworldvendor.Models;

namespace flatworldvendor.Controllers
{
    public class RequistionsController : Controller
    {
        private readonly flatworldvendorContext _context;

        public RequistionsController(flatworldvendorContext context)
        {
            _context = context;
        }

        // GET: Requistions
        public async Task<IActionResult> Index()
        {
              return View(await _context.Requistion.ToListAsync());
        }

        // GET: Requistions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Requistion == null)
            {
                return NotFound();
            }

            var requistion = await _context.Requistion
                .FirstOrDefaultAsync(m => m.ReqId == id);
            if (requistion == null)
            {
                return NotFound();
            }

            return View(requistion);
        }

        // GET: Requistions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Requistions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReqId,PotentialId,Complexity,ClientName,ProjectType,SalesPerson,ProjectManager,StartDate,EndDate,Status,ExpectedStartDate,Tenurre,MinExprience,MaxExprience,Description,Resource,OpenPosition")] Requistion requistion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requistion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requistion);
        }

        // GET: Requistions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Requistion == null)
            {
                return NotFound();
            }

            var requistion = await _context.Requistion.FindAsync(id);
            if (requistion == null)
            {
                return NotFound();
            }
            return View(requistion);
        }

        // POST: Requistions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReqId,PotentialId,Complexity,ClientName,ProjectType,SalesPerson,ProjectManager,StartDate,EndDate,Status,ExpectedStartDate,Tenurre,MinExprience,MaxExprience,Description,Resource,OpenPosition")] Requistion requistion)
        {
            if (id != requistion.ReqId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requistion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequistionExists(requistion.ReqId))
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
            return View(requistion);
        }

        // GET: Requistions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Requistion == null)
            {
                return NotFound();
            }

            var requistion = await _context.Requistion
                .FirstOrDefaultAsync(m => m.ReqId == id);
            if (requistion == null)
            {
                return NotFound();
            }

            return View(requistion);
        }

        // POST: Requistions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Requistion == null)
            {
                return Problem("Entity set 'flatworldvendorContext.Requistion'  is null.");
            }
            var requistion = await _context.Requistion.FindAsync(id);
            if (requistion != null)
            {
                _context.Requistion.Remove(requistion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequistionExists(int id)
        {
          return _context.Requistion.Any(e => e.ReqId == id);
        }
    }
}
