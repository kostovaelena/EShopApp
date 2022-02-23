
using Microsoft.AspNetCore.Identity;
using EShopApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopApp.Domain
{
    public class ESApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public virtual ShoppingCart UserCart { get; set; }
        public string Role { get; set; }
    }
}
