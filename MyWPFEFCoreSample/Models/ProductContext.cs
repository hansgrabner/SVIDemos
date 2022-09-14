using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFEFCoreSample.Models
{
    //https://docs.microsoft.com/en-us/ef/core/get-started/wpf
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite(
                "Data Source=products.db");
           // optionsBuilder.UseLazyLoadingProxies();
            
        }
    }
}
