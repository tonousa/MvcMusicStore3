using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore3.Models;

namespace MvcMusicStore3.Controllers
{
    public class HomeController : Controller
    {
        public MusicStoreEntities storeDB = new MusicStoreEntities();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            //return "Hello from Home";
            // Get the most popular albums
            var albums = GetTopSellingAlbums(5);
            return View(albums);
        }

        private List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }


       
    }
}
