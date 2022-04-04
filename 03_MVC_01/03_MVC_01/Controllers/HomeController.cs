using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_MVC_01.Controllers
{
    //Tüm Controller'lar Controlloer kısmından miras alırlar.
    //Öyleyse bir requesti karşılayacak bir özellik kazanmasını
    //istyorsak ilgili class'ı Controller sınıfından türetmeliyiz.
    public class HomeController : Controller
    {
        //Eğer bir metod Controller içinde ise ona ActionMethod diyeceğiz
        //Hatta çoğu action olarak tabir edeceğiz.

        //Bu action uygulamanın ana dizinine istek gönderildiğinde 
        //tetiklenecektir.
        public IActionResult Index()
        {
            //Eğer View metodu bu şekilde kullanılırsa
            //yani parantez içi boş bırakılırsa, parametresiz kullanılırsa
            //içinde bulundugu actionın adındaki View'i arar veonu döndürür.
            return View();
        }
    }
}
