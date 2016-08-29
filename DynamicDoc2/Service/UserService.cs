using System;
using System.Collections.Generic;
using DynamicDoc2.Models;
using DynamicDoc2.IService;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.Service
{
    public class UserService : IUserService
    {
        private IUserDataAccess UserDataAccess;

        public UserService(IUserDataAccess UserDataAccess)
        {
            this.UserDataAccess = UserDataAccess;
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