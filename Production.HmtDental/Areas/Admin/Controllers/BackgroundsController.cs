using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Production.HmtDental.Context;
using Production.HmtDental.Models;

namespace Production.HmtDental.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BackgroundsController : Controller
    {
        private readonly HmtContext _context;

        public BackgroundsController(HmtContext context)
        {
            _context = context;
        }

        // GET: Admin/Background
        public async Task<IActionResult> Index()
        {
            return View(await _context.Background.ToListAsync());
            //var a = _context.Background.ToList();
            //return View(a);
        }

        // GET: Admin/Background/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var background = await _context.Background
                .FirstOrDefaultAsync(m => m.Id == id);
            if (background == null)
            {
                return NotFound();
            }

            return View(background);
        }

        // GET: Admin/Background/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Background/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Hotline,Landline,Slogan,Address,Email")] Background background)
        {
            if (ModelState.IsValid)
            {
                _context.Add(background);
                await _context.SaveChangesAsync();
                return RedirectToAction("Backgrounds", "Admin");
            }
            return View(background);
        }

        // GET: Admin/Background/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var background = await _context.Background.FindAsync(id);
            if (background == null)
            {
                return NotFound();
            }
            return View(background);
        }

        // POST: Admin/Background/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Hotline,Landline,Slogan,Address,Email")] Background background)
        {
            if (id != background.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(background);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BackgroundExists(background.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Backgrounds", "Admin");
            }
            return View(background);
        }

        // GET: Admin/Background/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var background = await _context.Background.FindAsync(id);
            _context.Background.Remove(background);
            await _context.SaveChangesAsync();
           
            if (background == null)
            {
                return NotFound();
            }

            return RedirectToAction("Background", "Admin");
        }

        // POST: Admin/Background/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var background = await _context.Background.FindAsync(id);
            _context.Background.Remove(background);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Backgrounds");
        }

        private bool BackgroundExists(int id)
        {
            return _context.Background.Any(e => e.Id == id);
        }
    }
}
