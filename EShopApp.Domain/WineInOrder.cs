using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopApp.Domain
{
    public class WineInOrder : BaseEntity
    {
        public Guid WineId { get; set; }
        public Wine OrderedWine { get; set; }

        public Guid OrderId { get; set; }
        public Order UserOrder { get; set; }
        public int Quantity { get; set; }

    }
}
