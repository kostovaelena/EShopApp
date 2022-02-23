using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace EShopApp.Services.Interface
{
    public interface IProductService
    {
        List<Wine> GetAllProducts();
        Wine GetDetailsForProduct(Guid? id);
        void CreateNewProduct(Wine p);
        void UpdeteExistingProduct(Wine p);
        AddToShoppingCart GetShoppingCartInfo(Guid? id);
        void DeleteProduct(Guid id);
        bool AddToShoppingCart(AddToShoppingCart item, string userID);
        List<Wine> GetFilteredWines();
        List<Wine> FilterByKategorija(Kategorija kategorija);

    }
}
