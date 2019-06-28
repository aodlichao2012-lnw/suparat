using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Ecom.Dbcontext
{
    public class DBcontext : IdentityDbContext<Customer , ApplicationRole , string>
    {
        public DBcontext(DbContextOptions<DBcontext> options):base(options)
        {

        }

        public DbSet<ApplicationRole> applicationRoles { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<CartItem> cartItems { get; set; }
        public DbSet<Category>  categories { get; set; }
        public DbSet<Customer>  customers { get; set; }
        public DbSet<Order>  orders { get; set; }
        public DbSet<OrderLine> orderLines { get; set; }
        public DbSet<Picture> pictures { get; set; }
        public DbSet<Product>  products { get; set; }
        public DbSet<SubCategory>  subCategories { get; set; }

    }

}
