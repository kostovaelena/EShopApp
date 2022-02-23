using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopApp.Services.Interface
{
    public interface IOrderService
    {
        List<Order> getAllOrders();

        Order getOrderDetails(BaseEntity model);

        List<Wine> GetAllProducts();
    }
}
