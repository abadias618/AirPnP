using System;
using System.Collections.Generic;
using System.Text;
using Bottom_Scroll.Model;

namespace Bottom_Scroll.Service
{
    public class ProductService
    {
        public List<Product> GetProductsList()
        {
            return new List<Product>()
            {
                new Product(){ProductName="Salt lake", Price=43
                , ImageUrl= "SaltLake.png"},
                new Product(){ProductName="Vivint Arena", Price=40
                , ImageUrl= "VivintArena.png"},
                new Product(){ProductName="The Capitol", Price=35
                , ImageUrl= "TheCapitol.png"},
                new Product(){ProductName="LDS Business College", Price=43
                , ImageUrl= "LDSBC.png"},
                new Product(){ProductName="Crown Burger", Price=40
                , ImageUrl= "CrownBurger.png"},
                new Product(){ProductName="The view", Price=45
                , ImageUrl= "TheView.png"},
            };

          }
    }
}
