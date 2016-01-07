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

        public String Browse()
        {
            return "Hello from the Store.Browse()";
        }

        public String Details()
        {
            return "Hello from the Store.Details()";
        }
    }
}
