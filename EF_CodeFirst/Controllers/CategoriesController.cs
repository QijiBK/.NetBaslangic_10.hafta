using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef_CodeFirst.Models;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_CodeFirst.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly LibraryContext _context;
        public CategoriesController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories
            .Where(x =>x.IsDeleted==false)
            .ToList();
            return View(categories);
        }
         public IActionResult GetDeletedCategories()
        {
            var dCategories = _context.Categories
            .Where(y =>y.IsDeleted==true)
            .ToList();
            return View(dCategories);
        }
        public IActionResult Restore(int id)
        {
            var dCat = _context.Categories.Find(id);
            return View(dCat);
        }
        [HttpPost,ActionName("Restore")]
        public IActionResult GetRestore(int id)
        {
            var dCat = _context.Categories.Find(id);
            dCat.IsDeleted=false;
            _context.Categories.Update(dCat);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _context.Categories.Find(id);
            category.IsDeleted=true;
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Category cat = _context.Categories.Find(id);
            return View(cat);
        }
        
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        
    }
}