using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public string Index()
        {
            return "Index page";
        }

        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                // shortcut for RedirectResult.
                return Redirect("/");
            }

            //accepts a string for content.  shortcut for ContentResult.
            return Content("Detail page");
        }
    }
}