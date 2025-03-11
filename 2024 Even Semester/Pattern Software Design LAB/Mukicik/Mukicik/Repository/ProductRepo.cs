using Mukicik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik.Repository
{
    public class ProductRepo
    {
        Database1Entities db = new Database1Entities();
        public void InsertProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
        }

        public void IncreaseProductPrice(int productId, int incPrice)
        {
            Product product = GetProductById(productId);
            if (product != null)
            {
                product.ProductPrice += incPrice;
                db.SaveChanges();
            }
        }

        public void DecreaseProductPrice(int productId, int decPrice)
        {
            Product product = GetProductById(productId);
            if (product != null)
            {
                product.ProductPrice -= decPrice;
                db.SaveChanges();
            }
        }

    }
}