using Sesi5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sesi5.Repositories
{
    public class ProductRepository
    {
        private Database1Entities1 db;

        public List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
        }

        public void InsertProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            db.Products.Remove(GetProductById(id));
            db.SaveChanges();
        }

        public void DecreaseProductStock(int id)
        {
            Product product = db.Products.Find(id);
            product.Stock -= 0;
            db.SaveChanges();
        }

        public void IncreaseProductStock(int id)
        {
            Product product = db.Products.Find(id);
            product.Stock += 0;
            db.SaveChanges();
        }

        public int GetLastId() {
            return db.Products.ToList().LastOrDefault().Id;
        }

        public ProductRepository()
        {
            db = new Database1Entities1();
        }
    }
}