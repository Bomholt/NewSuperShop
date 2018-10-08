using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SuperShop
{
    public class SuperSuitAppContext : DbContext
    {
        public SuperSuitAppContext(DbContextOptions<SuperSuitAppContext> opt) : base(opt)
        {
            //Constructor to Super Class
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Relations between models
        }

        public DbSet<SuperSuit> superSuits { get; set; }
    }
}
