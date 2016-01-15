using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public String Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        public String Details(int id)
        {
            string message = "Store Details, ID = " + id;
            return message;
        }
    }
}
