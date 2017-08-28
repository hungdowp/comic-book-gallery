using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>this is a asm description</p>";
            ViewBag.Artists = new string[]
            {
                "script: dan slott",
                "pencils: humberto ramos"
            };
            return View();

        }
    }
}