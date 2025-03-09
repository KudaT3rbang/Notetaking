using Sesi4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace Sesi4.Factories
{
    public class ItemFactory
    {
        static Database1Entities1 db = new Database1Entities1();

        public static Item CreateItem(String name, String type, int price, int stock)
        {
            Item item = new Item();
            item.name = name;
            item.type_id = type;
            item.price = price;
            item.stock = stock;
            item.id = GenerateId();
            return item;
        }

        private static string GenerateId()
        {
            Item last = db.Items.ToList().LastOrDefault();
            if (last == null)
            {
                return "IT001";
            } else
            {
                int num = Convert.ToInt32(last.id.Substring(2));
                num++;
                return String.Format("IT{0:000}", num);
            }
        }
    }
}