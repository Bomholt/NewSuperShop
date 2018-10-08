using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SuperShop
{
    public class DBInitializer
    {
        public static void SeedDB(SuperSuitAppContext ctx)
        {
            ctx.Database.EnsureDeleted(); 
            ctx.Database.EnsureCreated();

            var superSuit1 = ctx.superSuits.Add(new SuperSuit()
            {
                
                Name = "Captain America Suit",
                Type = "Captain America",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            ctx.SaveChanges();
             
        }

    }
}
