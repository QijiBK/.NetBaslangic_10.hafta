using _07_DersBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_DersBlogSitesi.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            var lessons = new List<Lesson>
            {
                new Lesson {ID=1, LessonName="Html", Category="Frontend"},
                new Lesson {ID=2, LessonName="Css", Category="Frontend"},
                new Lesson {ID=3, LessonName="Bootstrap", Category="Frontend"},
                new Lesson {ID=4, LessonName="Javascript", Category="Frontend"},
                new Lesson {ID=5, LessonName="Jquery", Category="Frontend"},
                new Lesson {ID=6, LessonName="React", Category="Frontend"},
                new Lesson {ID=7, LessonName="C#", Category="Backend"},
                new Lesson {ID=8, LessonName="PHP", Category="Backend"}
            };


            return View(lessons);
        }
    }
}
