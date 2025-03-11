using LatihanKuis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatihanKuis.Factory
{
    public class UserFactory
    {
        Database1Entities db = new Database1Entities();
        public User CreateUser(string username, string password)
        {
            return new User()
            {
                UserId = GenerateUserId(),
                Username = username,
                Password = password
            };
        }

        private string GenerateUserId()
        {
            User last = db.Users.ToList().LastOrDefault();
            if (last == null)
            {
                return "US001";
            } else
            {
                int num = Convert.ToInt32(last.UserId.Substring(2));
                num++;
                return String.Format("US{0:000}", num);
            }
        }
    }
}