using Mukicik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik.Factories
{
    public class CategoryFactory
    {
        Database1Entities db = new Database1Entities();
        public Category CreateCategory(int categoryId, string categoryName)
        {
            return new Category()
            {
                CategoryId = GenerateCategoryId(),
                CategoryName = categoryName
            };
        }

        public int GenerateCategoryId()
        {
            if(db.Categories.Any())
            {
                return db.Categories.Max(c => c.CategoryId) + 1;
            } else
            {
                return 1;
            }
        }
    }
}