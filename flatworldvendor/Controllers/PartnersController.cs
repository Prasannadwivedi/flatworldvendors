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
    public class PartnersController : Controller
    {
        private readonly flatworldvendorContext _context;

        public PartnersController(flatworldvendorContext context)
        {
            _context = context;
        }

        // GET: Partners
        public async Task<IActionResult> Index()
        {
              return View(await _context.Partner.ToListAsync());
        }

        // GET: Partners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Partner == null)
            {
                return NotFound();
            }

            var partner = await _context.Partner
                .FirstOrDefaultAsync(m => m.PartnersID == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // GET: Partners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Partners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartnersID,PartnerName,RegistredDate,Location,Country,SPOCName,SPOCEmail,Status,Skillset,TemAddress,BillAddress")] Partner partner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partner);
        }

        // GET: Partners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Partner == null)
            {
                return NotFound();
            }

            var partner = await _context.Partner.FindAsync(id);
            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        // POST: Partners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PartnersID,PartnerName,RegistredDate,Location,Country,SPOCName,SPOCEmail,Status,Skillset,TemAddress,BillAddress")] Partner partner)
        {
            if (id != partner.PartnersID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartnerExists(partner.PartnersID))
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
            return View(partner);
        }

        // GET: Partners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Partner == null)
            {
                return NotFound();
            }

            var partner = await _context.Partner
                .FirstOrDefaultAsync(m => m.PartnersID == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // POST: Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Partner == null)
            {
                return Problem("Entity set 'flatworldvendorContext.Partner'  is null.");
            }
            var partner = await _context.Partner.FindAsync(id);
            if (partner != null)
            {
                _context.Partner.Remove(partner);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartnerExists(int id)
        {
          return _context.Partner.Any(e => e.PartnersID == id);
        }
    }
}
