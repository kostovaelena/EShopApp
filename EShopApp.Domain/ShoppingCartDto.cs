using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopApp.Domain
{
    public class ShoppingCartDto
    {
        public List<WineInShoppingCart> Wines { get; set; }
        public double TotalPrice { get; set; }
    }
}
