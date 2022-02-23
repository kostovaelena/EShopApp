using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopApp.Domain
{
    public class ShoppingCart : BaseEntity 
    {
      
        public virtual ICollection<WineInShoppingCart> WineInShoppingCarts { get; set; }
        public ESApplicationUser Owner { get; set; }
        public string OwnerId { get; set; }

    }
}
