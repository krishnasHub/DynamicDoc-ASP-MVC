using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.Models;
using DynamicDoc2.DataAccess;

namespace DynamicDoc2.Service
{
    public class UserService : IUserService
    {
        private UserDataAccess UserDataAccess;

        public UserService()
        {
            UserDataAccess = new UserDataAccess();
        }

        public List<User> GetAllUsers()
        {
            return UserDataAccess.GetAllUsers();
        }

        public User GetUserById(int userId)
        {
            return UserDataAccess.GetUserById(userId);
        }

        public User GetUserByName(string userName)
        {
            return UserDataAccess.GetUserByName(userName);
        }

        public void SaveUser(User user)
        {
            UserDataAccess.SaveUser(user);
        }
    }
}