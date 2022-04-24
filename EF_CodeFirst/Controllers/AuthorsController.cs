using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef_CodeFirst.Models;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_CodeFirst.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly LibraryContext _context;
        public AuthorsController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var authors = _context.Authors
            .Where(x=>x.IsDeleted==false)
            .ToList();
            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            _context.Add(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetDeletedAuthors()
        {
            var authors = _context.Authors
            .Where(m=>m.IsDeleted==true)
            .ToList();
            return View(authors);
        }
        public IActionResult Delete(int id)
        {
            var dAuthor = _context.Authors.Find(id);
            return View(dAuthor);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var dAuthor = _context.Authors.Find(id);
            dAuthor.IsDeleted=true;
            _context.Authors.Update(dAuthor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var eAuthor = _context.Authors.Find(id);
            return View(eAuthor);
        }
        [HttpPost]
        public IActionResult Edit(Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var author = _context.Authors.Find(id);
            return View(author);
        }
         public IActionResult Restore(int id)
        {
            var rAuthor = _context.Authors.Find(id);
            return View(rAuthor);
        }
        [HttpPost,ActionName("Restore")]
        public IActionResult GetRestore(int id)
        {
            var rAuthor = _context.Authors.Find(id);
            rAuthor.IsDeleted=false;
            _context.Authors.Update(rAuthor);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        
    }
}