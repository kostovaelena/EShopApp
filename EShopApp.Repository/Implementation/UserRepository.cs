
using EShopApp.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EShopApp.Repository;
using EShopApp.Domain;


namespace EShopApp.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<ESApplicationUser> entities;
        string errorMessage = string.Empty;
        

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<ESApplicationUser>();
        }
        public IEnumerable<ESApplicationUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public ESApplicationUser Get(string id)
        {
            return entities
               .Include(z => z.UserCart)
               .Include("UserCart.WineInShoppingCarts")
               .Include("UserCart.WineInShoppingCarts.Wine")
               .SingleOrDefault(s => s.Id == id);
        }
        public void Insert(ESApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(ESApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(ESApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        
    }
}
