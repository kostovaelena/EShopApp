using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShopApp.Domain
{

    public enum Kategorija
    {
        CRVENO,
        CRNO,
        BELO,
        ROZE,
        PENLIVO
    }

    public class Wine : BaseEntity
    {
       

        [Required]
        public string Image { get; set; }
        [Required]
        [DisplayName("Винарија")]
        public string Vinarija { get; set; }
        [Required]
        [DisplayName("Земја на производство")]
        public string Zemja { get; set; }
        [Required]
        [DisplayName("Година на производство")]
        public int Godina { get; set; }
        [Required]
        [DisplayName("Категорија")]
        public Kategorija Kategorija { get; set; }
        [Required]
        [DisplayName("Цена")]
        public int Price { get; set; }


        //[Required]
        //[DisplayName("Датум и време на на емитување")]
        //public DateTime ValidDate { get; set; }

        public virtual ICollection<WineInShoppingCart> WineInShoppingCarts { get; set; }
        public IEnumerable<WineInOrder> WineInOrders { get; set; }
        






    }
}
