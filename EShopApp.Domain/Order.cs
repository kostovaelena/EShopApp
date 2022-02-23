using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopApp.Domain
{
    public class Order : BaseEntity
    {
        
        public string UserId { get; set; }
        public ESApplicationUser User { get; set; }

        public IEnumerable<WineInOrder> WineInOrders { get; set; }
    }
}
