using Mukicik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik.Factories
{
    public class UserFactory
    {
        Database1Entities db = new Database1Entities();
        public User CreateUser(string username, string userEmail, string userPassword, string userGender, DateTime userDob, string userProfilePicture)
        {
            return new User()
            {
                UserId = GenerateUserId(),
                Username = username,
                UserEmail = userEmail,
                UserPassword = userPassword,
                UserGender = userGender,
                UserDOB = userDob,
                UserProfilePicture = userProfilePicture
            };
        }

        public int GenerateUserId()
        {
            if (db.Users.Any())
            {
                return db.Users.Max(u => u.UserId) + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}