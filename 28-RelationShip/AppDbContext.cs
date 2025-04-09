using _28_RelationShip.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_RelationShip
{
    class AppDbContext: DbContext
    {
        public DbSet<Tag> Customers { get; set; }
        public DbSet<ProductDetail> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HalkBank1;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;");
        }
        

    }
}
