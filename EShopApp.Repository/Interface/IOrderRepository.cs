using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopApp.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        Order getOrderDetails(BaseEntity model);
    }
}
