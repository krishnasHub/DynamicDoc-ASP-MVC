using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDoc2.DataAccess
{
    public class LoginDataAccess : NhibernateDataProvider
    {


        public bool CheckLogin(string userName, string password)
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<User>();
            var count = criteria.List<User>().Count<User>(u => ((userName.Contains("@") && u.EmailId.Equals(userName))
                                                        || u.Name.Equals(userName)) && u.Password.Equals(password));
            return count == 1;
        }

        public void Logout(string userName)
        {
            var userDao = new UserDataAccess();
            var user = userDao.GetUserByName(userName);
            user.LoggedIn = 0;
            userDao.SaveUser(user);
        }
    }
}