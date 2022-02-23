
using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopApp.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<ESApplicationUser> GetAll();
        ESApplicationUser Get(string id);
        void Insert(ESApplicationUser entity);
        void Update(ESApplicationUser entity);
        void Delete(ESApplicationUser entity);
    }
}
