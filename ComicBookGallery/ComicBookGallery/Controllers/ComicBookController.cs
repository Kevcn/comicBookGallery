using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBookRepository accessRepository = null;

        public ComicBookController()
        {
            accessRepository = new ComicBookRepository();
        }

        public string Index()
        {
            return "Index page";
        }

        public ActionResult Detail(int? id)
        {
            // create a new Model in the controller
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = accessRepository.GetComicBook((int)id);

            // Strongly typed, expose the model instance through its model properties. 
            return View(comicBook);
        }
    }
}