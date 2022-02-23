using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopApp.Domain
{
    public class WineInShoppingCart : BaseEntity
    {
        public Guid WineId { get; set; }
        public Guid ShoppingCartId { get; set; }
        public Wine Wine { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int Quantity { get; set; }

    }
}
