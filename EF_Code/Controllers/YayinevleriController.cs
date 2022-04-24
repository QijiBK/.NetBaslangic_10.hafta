using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Code.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_Code.Controllers
{
    public class YayinevleriController : Controller
    {
        private readonly KutuphaneAksamContext _context;
        public YayinevleriController(KutuphaneAksamContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Yayinevleris.ToList());
        }
        public IActionResult Details(int id)
        {
            Yayinevleri yayinevleri = _context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }
        public IActionResult Edit(int id)
        {
            Yayinevleri yayinevleri = _context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,Ad,Adres,Tel")] Yayinevleri yayinevleri)
        {
            _context.Update(yayinevleri);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var silinecekYayinevi = _context.Yayinevleris.Find(id);
            return View(silinecekYayinevi);
        }
        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekYayinevi = _context.Yayinevleris.Find(id);
            _context.Yayinevleris.Remove(silinecekYayinevi);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Yayinevleri yayinevleri)
        {
            _context.Add(yayinevleri);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}