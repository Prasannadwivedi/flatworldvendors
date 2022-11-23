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
    public class User1Controller : Controller
    {
        private readonly flatworldvendorContext _context;

        public User1Controller(flatworldvendorContext context)
        {
            _context = context;
        }

        // GET: User1
        public async Task<IActionResult> Index()
        {
              return View(await _context.User1.ToListAsync());
        }

        // GET: User1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.User1 == null)
            {
                return NotFound();
            }

            var user1 = await _context.User1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user1 == null)
            {
                return NotFound();
            }

            return View(user1);
        }

        // GET: User1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoleId,Name,Address,City,Email,Mobile,Password,Role")] User1 user1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user1);
        }

        // GET: User1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.User1 == null)
            {
                return NotFound();
            }

            var user1 = await _context.User1.FindAsync(id);
            if (user1 == null)
            {
                return NotFound();
            }
            return View(user1);
        }

        // POST: User1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoleId,Name,Address,City,Email,Mobile,Password,Role")] User1 user1)
        {
            if (id != user1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!User1Exists(user1.Id))
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
            return View(user1);
        }

        // GET: User1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.User1 == null)
            {
                return NotFound();
            }

            var user1 = await _context.User1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user1 == null)
            {
                return NotFound();
            }

            return View(user1);
        }

        // POST: User1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.User1 == null)
            {
                return Problem("Entity set 'flatworldvendorContext.User1'  is null.");
            }
            var user1 = await _context.User1.FindAsync(id);
            if (user1 != null)
            {
                _context.User1.Remove(user1);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool User1Exists(int id)
        {
          return _context.User1.Any(e => e.Id == id);
        }
    }
}
