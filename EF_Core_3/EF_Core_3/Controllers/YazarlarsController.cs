using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EF_Core_3.Models;

namespace EF_Core_3.Controllers
{
    public class YazarlarsController : Controller
    {
        private readonly KutuphaneAksamContext _context;

        public YazarlarsController(KutuphaneAksamContext context)
        {
            _context = context;
        }

        // GET: Yazarlars
        public async Task<IActionResult> Index()
        {
            var kutuphaneAksamContext = _context.Yazarlars.Include(y => y.Turler);
            return View(await kutuphaneAksamContext.ToListAsync());
        }

        // GET: Yazarlars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars
                .Include(y => y.Turler)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yazarlar == null)
            {
                return NotFound();
            }

            return View(yazarlar);
        }

        // GET: Yazarlars/Create
        public IActionResult Create()
        {
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd");
            return View();
        }

        // POST: Yazarlars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AdSoyad,Cinsiyet,DogumTarihi,Tel,Mail,TurlerId")] Yazarlar yazarlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yazarlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd", yazarlar.TurlerId);
            return View(yazarlar);
        }

        // GET: Yazarlars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars.FindAsync(id);
            if (yazarlar == null)
            {
                return NotFound();
            }
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd", yazarlar.TurlerId);
            return View(yazarlar);
        }

        // POST: Yazarlars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AdSoyad,Cinsiyet,DogumTarihi,Tel,Mail,TurlerId")] Yazarlar yazarlar)
        {
            if (id != yazarlar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yazarlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YazarlarExists(yazarlar.Id))
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
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd", yazarlar.TurlerId);
            return View(yazarlar);
        }

        // GET: Yazarlars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars
                .Include(y => y.Turler)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yazarlar == null)
            {
                return NotFound();
            }

            return View(yazarlar);
        }

        // POST: Yazarlars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yazarlar = await _context.Yazarlars.FindAsync(id);
            _context.Yazarlars.Remove(yazarlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YazarlarExists(int id)
        {
            return _context.Yazarlars.Any(e => e.Id == id);
        }
    }
}
