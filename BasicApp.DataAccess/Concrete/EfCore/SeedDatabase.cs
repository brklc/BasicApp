using BasicApp.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new BasicContext();

            if(context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }

                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category(){Name="Telefon"},
            new Category(){Name="Bilgisayar"},
             new Category(){Name="Elektronik"}
        };

        private static Product[] Products =
       {
           new Product(){Name="Samsung S5", Price=2000, ImageUrl="1.jpg",Description="Samsung Telefon"},
           new Product(){Name="Samsung S6", Price=3000, ImageUrl="2.jpg",Description="Samsung Telefon"},
           new Product(){Name="Samsung S7", Price=4000, ImageUrl="3.jpg",Description="Samsung Telefon"},
        };

        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory(){Product = Products[0],Category = Categories[0]},
             new ProductCategory(){Product = Products[0],Category = Categories[1]},
              new ProductCategory(){Product = Products[1],Category = Categories[0]},
               new ProductCategory(){Product = Products[1],Category = Categories[2]}
        };
    }
}
