using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    public class KitaplarController : Controller
    {
        private readonly KutuphaneAksamContext _context;
        public KitaplarController(KutuphaneAksamContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            return View(_context.Kitaplars.ToList());
        }
        public IActionResult Create()
        {
            ViewData["TurlerId"] = new SelectList(_context.Turlers, "Id", "TurAd");
            ViewData["YayinEvleriId"] = new SelectList(_context.Yayinevleris, "Id", "Ad");
            ViewData["YazarlarId"] = new SelectList(_context.Yazarlars, "Id", "AdSoyad");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Kitaplar kitap)
        {
            _context.Add(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(string id)
        {
            var seciliKitap = _context.Kitaplars
            .Include(k => k.Turler)
            .Include(k => k.YayinEvleri)
            .Include(k => k.Yazarlar)
            .First(s => s.Isbn ==id);
            return View(seciliKitap);
        }
        public IActionResult Edit(string id)
        {
            var secilenKitap=_context.Kitaplars.Find(id);
            ViewData["Tur"]= new SelectList(_context.Turlers,"Id","TurAd",secilenKitap.TurlerId);
            ViewData["Yazarlar"]=new SelectList(_context.Yazarlars,"Id","AdSoyad",secilenKitap.YazarlarId);
            ViewData["Yayinevleri"]=new SelectList(_context.Yayinevleris,"Id","Ad",secilenKitap.YayinEvleriId);
            return View(secilenKitap);
        }
        [HttpPost]
        public IActionResult Edit(Kitaplar kitap)
        {
            _context.Update(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            var silinecekKitap = _context.Kitaplars
            .Include(k => k.Turler)
            .Include(k => k.YayinEvleri)
            .Include(k => k.Yazarlar)
            .First(s => s.Isbn ==id);
            return View(silinecekKitap);
        }
        [HttpPost,ActionName("DeleteConfirmed") ]
        public IActionResult DeleteConfirmed(string id)
        {
            var silinecekKitapp =_context.Kitaplars.Find(id);
            _context.Kitaplars.Remove(silinecekKitapp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}