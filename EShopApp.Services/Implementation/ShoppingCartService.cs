using EShopApp.Domain;
using EShopApp.Repository.Interface;
using EShopApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShopApp.Services.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<ShoppingCart> _shoppingCartRepositorty;
        private readonly IRepository<Order> _orderRepositorty;
        private readonly IRepository<WineInOrder> _productInOrderRepositorty;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<EmailMessage> _mailRepository;

        public ShoppingCartService(IRepository<EmailMessage> mailRepository, IRepository<ShoppingCart> shoppingCartRepository, IRepository<WineInOrder> productInOrderRepositorty, IRepository<Order> orderRepositorty, IUserRepository userRepository)
        {
            _shoppingCartRepositorty = shoppingCartRepository;
            _userRepository = userRepository;
            _orderRepositorty = orderRepositorty;
            _productInOrderRepositorty = (IRepository<WineInOrder>)productInOrderRepositorty;
            _mailRepository = mailRepository;
        }

        public bool deleteProductFromShoppingCart(string userId, Guid id)
        {
            if (!string.IsNullOrEmpty(userId) && id != null)
            {
                //Select * from Users Where Id LIKE userId

                var loggedInUser = this._userRepository.Get(userId);

                var userShoppingCart = loggedInUser.UserCart;

                var itemToDelete = userShoppingCart.WineInShoppingCarts.Where(z => z.WineId.Equals(id)).FirstOrDefault();

                userShoppingCart.WineInShoppingCarts.Remove(itemToDelete);

                this._shoppingCartRepositorty.Update(userShoppingCart);

                return true;
            }

            return false;
        }

        public ShoppingCartDto getShoppingCartInfo(string userId)
        {
            var loggedInUser = this._userRepository.Get(userId);

            var userShoppingCart = loggedInUser.UserCart;

            var AllProducts = userShoppingCart.WineInShoppingCarts.ToList();

            var allProductPrice = AllProducts.Select(z => new
            {
                Price = z.Wine.Price,
                Quanitity = z.Quantity
            }).ToList();

            var totalPrice = 0;


            foreach (var item in allProductPrice)
            {
                totalPrice += item.Quanitity * item.Price;
            }


            ShoppingCartDto scDto = new ShoppingCartDto
            {
                Wines = AllProducts,
                TotalPrice = totalPrice
            };


            return scDto;

        }

        public bool orderNow(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                //Select * from Users Where Id LIKE userId

                var loggedInUser = this._userRepository.Get(userId);

                var userShoppingCart = loggedInUser.UserCart;

                EmailMessage mail = new EmailMessage();
                mail.MailTo = loggedInUser.Email;
                mail.Subject = "Successfully created order";
                mail.Status = false;

                Order order = new Order
                {
                    Id = Guid.NewGuid(),
                    User = loggedInUser,
                    UserId = userId
                };

                this._orderRepositorty.Insert(order);

                List<WineInOrder> productInOrders = new List<WineInOrder>();

                var result = userShoppingCart.WineInShoppingCarts.Select(z => new WineInOrder
                {
                    Id = Guid.NewGuid(),
                    WineId = z.Wine.Id,
                    OrderedWine = z.Wine,
                    OrderId = order.Id,
                    UserOrder = order,
                    Quantity = z.Quantity
                }).ToList();

                StringBuilder sb = new StringBuilder();

                var totalPrice = 0;

                sb.AppendLine("Your order is completed. The order conains: ");

                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];

                    totalPrice += item.Quantity * item.OrderedWine.Price;

                    sb.AppendLine(i.ToString() + ". " + item.OrderedWine.Vinarija + " with price of: " + item.OrderedWine.Price +" MKD" + " and quantity of: " + item.Quantity);
                }

                sb.AppendLine("Total price: " + totalPrice.ToString() + " MKD");


                mail.Content = sb.ToString();


                productInOrders.AddRange(result);

                foreach (var item in productInOrders)
                {
                    this._productInOrderRepositorty.Insert(item);
                }

                loggedInUser.UserCart.WineInShoppingCarts.Clear();

                this._userRepository.Update(loggedInUser);
               this._mailRepository.Insert(mail);

                return true;
            }
            return false;
        }
    }
}
