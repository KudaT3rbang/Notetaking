using Mukicik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik.Repository
{
    public class UserRepo
    {
        Database1Entities db = new Database1Entities();

        public void InsertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }
        public User GetUserById(int id)
        {
            return db.Users.Find(id);
        }

        public User GetUserByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.UserEmail == email);
        }
    }
}