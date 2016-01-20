using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore3.Models
{
    public partial class ShoppingCart
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        string ShoppingCartId { get; set; }

    }
}