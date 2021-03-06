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
    public class KitaplarsController : Controller
    {
        private readonly KutuphaneAksamContext _context;

        public KitaplarsController(KutuphaneAksamContext context)
        {
            _context = context;
        }

        // GET: Kitaplars
        public async Task<IActionResult> Index()
        {
            var kutuphaneAksamContext = _context.Kitaplars.Include(k => k.Turler).Include(k => k.YayinEvleri).Include(k => k.Yazarlar);
            return View(await kutuphaneAksamContext.ToListAsync());
        }

        // GET: Kitaplars/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitaplar = await _context.Kitaplars
                .Include(k => k.Turler)
                .Include(k => k.YayinEvleri)
                .Include(k => k.Yazarlar)
                .FirstOrDefaultAsync(m => m.Isbn == id);
            if (kitaplar == null)
            {
                return NotFound();
            }

            return View(kitaplar);
        }

        // GET: Kitaplars/Create
        public IActionResult Create()
        {
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd");
            ViewData["YayinEvleriId"] = new SelectList(_context.Yayinevleris, "Id", "Ad");
            ViewData["YazarlarId"] = new SelectList(_context.Yazarlars, "Id", "AdSoyad");
            return View();
        }

        // POST: Kitaplars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Isbn,Ad,SayfaSayisi,Stok,TurlerId,YazarlarId,YayinEvleriId")] Kitaplar kitaplar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kitaplar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd", kitaplar.TurlerId);
            ViewData["YayinEvleriId"] = new SelectList(_context.Yayinevleris, "Id", "Ad", kitaplar.YayinEvleriId);
            ViewData["YazarlarId"] = new SelectList(_context.Yazarlars, "Id", "AdSoyad", kitaplar.YazarlarId);
            return View(kitaplar);
        }

        // GET: Kitaplars/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitaplar = await _context.Kitaplars.FindAsync(id);
            if (kitaplar == null)
            {
                return NotFound();
            }
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd", kitaplar.TurlerId);
            ViewData["YayinEvleriId"] = new SelectList(_context.Yayinevleris, "Id", "Ad", kitaplar.YayinEvleriId);
            ViewData["YazarlarId"] = new SelectList(_context.Yazarlars, "Id", "AdSoyad", kitaplar.YazarlarId);
            return View(kitaplar);
        }

        // POST: Kitaplars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Isbn,Ad,SayfaSayisi,Stok,TurlerId,YazarlarId,YayinEvleriId")] Kitaplar kitaplar)
        {
            if (id != kitaplar.Isbn)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kitaplar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KitaplarExists(kitaplar.Isbn))
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
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd", kitaplar.TurlerId);
            ViewData["YayinEvleriId"] = new SelectList(_context.Yayinevleris, "Id", "Ad", kitaplar.YayinEvleriId);
            ViewData["YazarlarId"] = new SelectList(_context.Yazarlars, "Id", "AdSoyad", kitaplar.YazarlarId);
            return View(kitaplar);
        }

        // GET: Kitaplars/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitaplar = await _context.Kitaplars
                .Include(k => k.Turler)
                .Include(k => k.YayinEvleri)
                .Include(k => k.Yazarlar)
                .FirstOrDefaultAsync(m => m.Isbn == id);
            if (kitaplar == null)
            {
                return NotFound();
            }

            return View(kitaplar);
        }

        // POST: Kitaplars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var kitaplar = await _context.Kitaplars.FindAsync(id);
            _context.Kitaplars.Remove(kitaplar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KitaplarExists(string id)
        {
            return _context.Kitaplars.Any(e => e.Isbn == id);
        }
    }
}
