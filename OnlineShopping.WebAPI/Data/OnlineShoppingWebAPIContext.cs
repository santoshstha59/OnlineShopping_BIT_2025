using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.WebAPI.Models;
using OnlineShopping.Core;

namespace OnlineShopping.WebAPI.Data
{
    public class OnlineShoppingWebAPIContext : DbContext
    {
        public OnlineShoppingWebAPIContext (DbContextOptions<OnlineShoppingWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineShopping.WebAPI.Models.Category> Category { get; set; } = default!;
        public DbSet<OnlineShopping.WebAPI.Models.Product> Product { get; set; } = default!;
        public DbSet<OnlineShopping.Core.User> User { get; set; } = default!;
    }
}
