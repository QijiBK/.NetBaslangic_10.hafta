using _07_DersBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_DersBlogSitesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var articles = new List<Article>
            {
                new Article {ID=1,Title="Burak Korkmaz", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=2,Title="Burak Korkma", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=3,Title="Burak Korkm", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=4,Title="Burak Kork", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=5,Title="Burak Kor", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=6,Title="Burak Ko", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=7,Title="Burak K", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=8,Title="Burak Ko", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=9,Title="Burak Kor", Content="Merhabalar ben burak korkmaz nasilsiniz."}

            };
            /*MODEL BAZLI VERI TAŞIMA
            return View(articles); */
            //ViewBag ile taşıma
            //ViewBag.Articles = articles;
            //VIEWDATA ILE VERI TAŞIMA
            // ViewData["makaleler"] = articles;
            //Tempdata ile veri taşıma
            TempData["articles"] = articles;

            return View();
        }
        public IActionResult GetCards(int articles)
        {
            var article = new List<Article>
            {
                new Article {ID=1,Title="Burak Korkmaz", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=2,Title="Burak Korkma", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=3,Title="Burak Korkm", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=4,Title="Burak Kork", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=5,Title="Burak Kor", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=6,Title="Burak Ko", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=7,Title="Burak K", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=8,Title="Burak Ko", Content="Merhabalar ben burak korkmaz nasilsiniz."},
                new Article {ID=9,Title="Burak Kor", Content="Merhabalar ben burak korkmaz nasilsiniz."}

            };
            int id = Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);
            ViewBag.ID = article[id - 1];
            return View();
        }
            
        
    }
}
