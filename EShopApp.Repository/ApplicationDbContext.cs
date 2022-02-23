using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EShopApp.Domain;

using System;

namespace EShopApp.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ESApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Wine> Wines { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<WineInShoppingCart> WineInShoppingCarts { get; set; }
        public virtual DbSet<WineInOrder> WineInOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<EmailMessage> EmailMessages { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Wine>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

           /* builder.Entity<WineInShoppingCart>()
                .HasKey(z => new { z.WineId, z.ShoppingCartId });*/

            builder.Entity<WineInShoppingCart>()
               .HasOne(z => z.Wine)
               .WithMany(z => z.WineInShoppingCarts)
               .HasForeignKey(z => z.ShoppingCartId);

            builder.Entity<WineInShoppingCart>()
              .HasOne(z => z.ShoppingCart)
              .WithMany(z => z.WineInShoppingCarts)
              .HasForeignKey(z => z.WineId);

            builder.Entity<ShoppingCart>()
              .HasOne<ESApplicationUser>(z => z.Owner)
              .WithOne(z => z.UserCart)
              .HasForeignKey<ShoppingCart>(z => z.OwnerId);

/*
            builder.Entity<WineInOrder>()
              .HasKey(z => new { z.WineId, z.OrderId });*/

            builder.Entity<WineInOrder>()
                .HasOne(z => z.OrderedWine)
                .WithMany(z => z.WineInOrders)
                .HasForeignKey(z => z.OrderId);

            builder.Entity<WineInOrder>()
                .HasOne(z => z.UserOrder)
                .WithMany(z => z.WineInOrders)
                .HasForeignKey(z => z.WineId);
        }
    }
}
