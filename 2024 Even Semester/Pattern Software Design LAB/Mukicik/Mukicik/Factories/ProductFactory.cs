using Mukicik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik.Factories
{
    public class ProductFactory
    {
        public Product CreateProduct(int productId, string productName, int productPrice, string productImage, float productRating, int categoryId)
        {
            return new Product()
            {
                ProductId = productId,
                ProductName = productName,
                ProductPrice = productPrice,
                ProductImage = productImage,
                ProductRating = productRating,
                CategoryId = categoryId
            };
        }
    }
}