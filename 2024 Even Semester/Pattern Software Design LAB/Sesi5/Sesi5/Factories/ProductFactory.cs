using Sesi5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sesi5.Factories
{
    public class ProductFactory
    {
        public Product CreateProduct(int id, String name, String type, int price, int stock)
        {
            return new Product()
            {
                Id = id,
                Name = name,
                Type = type,
                Price = price,
                Stock = stock
            };
        }
    }
}