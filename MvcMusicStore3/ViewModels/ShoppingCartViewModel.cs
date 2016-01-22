using System.Collections.Generic;
using MvcMusicStore3.Models;

namespace MvcMusicStore3.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}