using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopApp.Domain
{
    public class AddToShoppingCart
    {
        public Wine SelectedWine { get; set; }
        public Guid WineId { get; set; }
        public int Quantity { get; set; }
    }
}
