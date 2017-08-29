using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>this is a asm description</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "dan slott", Role = "Script" },
                    new Artist() { Name = "humberto ramos", Role = "Pencils" },
                }
            };
            
            return View(comicBook);

        }
    }
}