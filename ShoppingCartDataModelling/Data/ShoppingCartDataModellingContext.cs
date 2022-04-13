#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingCartDataModelling.Model;

namespace ShoppingCartDataModelling.Data
{
    public class ShoppingCartDataModellingContext : DbContext
    {
        public ShoppingCartDataModellingContext (DbContextOptions<ShoppingCartDataModellingContext> options)
            : base(options)
        {
        }

        public DbSet<ShoppingCartDataModelling.Model.Products> Products { get; set; }

        public DbSet<ShoppingCartDataModelling.Model.Comments> Comments { get; set; }
    }
}
