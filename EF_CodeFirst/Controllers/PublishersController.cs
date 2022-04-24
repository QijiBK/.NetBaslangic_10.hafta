using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef_CodeFirst.Models;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_CodeFirst.Controllers
{
    public class PublishersController : Controller
    {
        private readonly LibraryContext _context;

        public PublishersController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var publishers = _context.Publishers
            .Where(x=>x.IsDeleted==false)
            .ToList();
            return View(publishers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Publisher publisher)
        {
            _context.Add(publisher);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult GetDeletedPublisher()
        {
            var publishers = _context.Publishers
            .Where(y=>y.IsDeleted==true)
            .ToList();
            return View(publishers);
        }
        public IActionResult Delete(int id)
        {
            var dPublisher = _context.Publishers.Find(id);
            return View(dPublisher);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var dPublisher = _context.Publishers.Find(id);
            dPublisher.IsDeleted=true;
            _context.Publishers.Update(dPublisher);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
         public IActionResult Edit(int id)
         {
             var ePublisher = _context.Publishers.Find(id);
             return View(ePublisher);
         }
         [HttpPost]
         public IActionResult Edit(Publisher ePublisher)
         {
             _context.Publishers.Update(ePublisher);
             _context.SaveChanges();
             return RedirectToAction("Index");
         }
        public IActionResult Details(int id)
        {
            Publisher publisher = _context.Publishers.Find(id);
            return View(publisher);
        }
         public IActionResult Restore(int id)
        {
            var rPublisher = _context.Publishers.Find(id);
            return View(rPublisher);
        }
        [HttpPost,ActionName("Restore")]
        public IActionResult GetRestore(int id)
        {
            var rPublisher = _context.Publishers.Find(id);
            rPublisher.IsDeleted=false;
            _context.Publishers.Update(rPublisher);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}