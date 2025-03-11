using LatihanKuis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace LatihanKuis.Repositories
{
    public class UserRepository
    {
        Database1Entities db = new Database1Entities();

        public void InsertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User GetUserByUsername(string username)
        {
            return db.Users.Where(x => x.Username == username).FirstOrDefault();
        }

        public void UpdatePassword(string userId, string passwords)
        {
            User user = db.Users.Find(userId);
            user.Password = passwords;
            db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}