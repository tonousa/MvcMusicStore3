using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore3.Models;

namespace MvcMusicStore3.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public String Index()
        {
            return "Hello from the store.Index()";
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}
