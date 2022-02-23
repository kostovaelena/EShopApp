using EShopApp.Domain;
using Microsoft.Extensions.Logging;
using EShopApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EShopApp.Repository.Interface;



namespace EShopApp.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Wine> _productRepository;
        private readonly IRepository<WineInShoppingCart> _productInShoppingCartRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<ProductService> _logger;
        public ProductService(IRepository<Wine> productRepository, ILogger<ProductService> logger, IRepository<WineInShoppingCart> productInShoppingCartRepository, IUserRepository userRepository)
        {
            _productRepository = productRepository;
            _userRepository = userRepository;
            _productInShoppingCartRepository = productInShoppingCartRepository;
            _logger = logger;
        }

        public bool AddToShoppingCart(AddToShoppingCart item, string userID)
        {

            var user = this._userRepository.Get(userID);

            var userShoppingCard = user.UserCart;

            if (item.WineId != null && userShoppingCard != null)
            {
                var product = this.GetDetailsForProduct(item.WineId);

                if (product != null)
                {
                    WineInShoppingCart itemToAdd = new WineInShoppingCart
                    {
                        Id = Guid.NewGuid(),
                        Wine = product,
                        WineId = product.Id,
                        ShoppingCart = userShoppingCard,
                        ShoppingCartId = userShoppingCard.Id,
                        Quantity = item.Quantity
                    };

                    this._productInShoppingCartRepository.Insert(itemToAdd);
                    _logger.LogInformation("Product was successfully added into ShoppingCart");
                    return true;
                }
                return false;
            }
            _logger.LogInformation("Something was wrong. ProductId or UserShoppingCard may be unaveliable!");
            return false;
        }


        public List<Wine> GetFilteredWines()
        {
            int now = DateTime.Now.Year;

            /*            return this._productRepository.GetAll().Where(t => (t.Godina.CompareTo(now) < 0) || (t.Godina.CompareTo(now) == 0)).ToList();
            */
            return this._productRepository.GetAll().OrderBy(x => x.Godina).ToList();

        }

        public List<Wine> FilterByKategorija(Kategorija kategorija)
        {
            return this._productRepository.GetAll().Where(t => t.Kategorija.Equals(kategorija)).ToList();
        }

        public void CreateNewProduct(Wine p)
        {
            this._productRepository.Insert(p);
        }

        public void DeleteProduct(Guid id)
        {
            var product = this.GetDetailsForProduct(id);
            this._productRepository.Delete(product);
        }

        public List<Wine> GetAllProducts()
        {
            _logger.LogInformation("GetAllProducts was called!");
            return this._productRepository.GetAll().ToList();
        }

        public Wine GetDetailsForProduct(Guid? id)
        {
            return this._productRepository.Get(id);
        }

        public AddToShoppingCart GetShoppingCartInfo(Guid? id)
        {
            var product = this.GetDetailsForProduct(id);
            AddToShoppingCart model = new AddToShoppingCart
            {
                SelectedWine = product,
                WineId = product.Id,
                Quantity = 1
            };

            return model;
        }

        public void UpdeteExistingProduct(Wine p)
        {
            this._productRepository.Update(p);
        }
    }
}
