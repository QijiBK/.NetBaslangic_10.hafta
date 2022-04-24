using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef_CodeFirst.Models;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Ef_CodeFirst.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryContext _context;
        public BooksController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var books = _context.Books
            .Where(x=>x.IsDeleted==false)
            .ToList();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _context.Books
            .Where(x=>x.IsDeleted==false)
            .Include(x=>x.Author)
            .Include(x=>x.Category)
            .Include(x=>x.Publisher)
            .FirstOrDefault(x=>x.BookId==id);
            return View(book);
        }
        public IActionResult Create()
        {   
            
            ViewData["CategoryId"] = new SelectList(_context.Categories.Where(a=>a.IsDeleted==false),"CategoryId","CategoryName");
            ViewData["AuthorId"] = new SelectList(_context.Authors.Where(a=>a.IsDeleted==false),"AuthorId","AuthorName");
            ViewData["PublisherId"] = new SelectList(_context.Publishers.Where(a=>a.IsDeleted==false),"PublisherId","PublisherName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book nBook)
        {
            _context.Add(nBook);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var book = _context.Books.Find(id);
            ViewData["CategoryId"] = new SelectList(_context.Categories.Where(a=>a.IsDeleted==false),"CategoryId","CategoryName",book.CategoryId);
            ViewData["AuthorId"] = new SelectList(_context.Authors.Where(a=>a.IsDeleted==false),"AuthorId","AuthorName",book.AuthorId);
            ViewData["PublisherId"] = new SelectList(_context.Publishers.Where(a=>a.IsDeleted==false),"PublisherId","PublisherName",book.CategoryId);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var dBook = _context.Books
            .Include(y=>y.Author)
            .Include(y=>y.Category)
            .Include(y=>y.Publisher)
            .FirstOrDefault(y=>y.BookId==id);
            return View(dBook);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var books = _context.Books.Find(id);
            books.IsDeleted=true;
            _context.Books.Update(books);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetDeletedBook()
        {
            var bookz = _context.Books
            .Where(h=>h.IsDeleted==true)
            .ToList();
            return View(bookz);
        }
        public IActionResult Restore(int id)
        {
            
            var book = _context.Books
            .Where(q=>q.IsDeleted==true)
            .Include(q=>q.Author)
            .Include(q=>q.Category)
            .Include(q=>q.Publisher)
            .FirstOrDefault(x=>x.BookId==id);
            return View(book);
        }
        [HttpPost,ActionName("Restore")]
        public IActionResult GetRestore(int id)
        {
            var rBook = _context.Books.Find(id);
            rBook.IsDeleted=false;
            _context.Books.Update(rBook);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        

    }
}