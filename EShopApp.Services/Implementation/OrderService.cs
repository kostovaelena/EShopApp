using EShopApp.Domain;
using EShopApp.Repository.Interface;
using EShopApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopApp.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public List<Order> getAllOrders()
        {
            return this._orderRepository.getAllOrders();
        }

        public List<Wine> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Order getOrderDetails(BaseEntity model)
        {
            return this._orderRepository.getOrderDetails(model);
        }
    }
}
