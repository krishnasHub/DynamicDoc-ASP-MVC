using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.DataAccess
{
    public class LoginDataAccess : NhibernateDataProvider, ILoginDataAccess
    {
        IUserDataAccess UserDataAccess;

        public LoginDataAccess(IUserDataAccess UserDataAccess)
        {
            this.UserDataAccess = UserDataAccess;
        }

        public bool CheckLogin(string userName, string password)
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<User>();
            var count = criteria.List<User>().Count<User>(u => ((userName.Contains("@") && u.EmailId.Equals(userName))
                                                        || u.Name.Equals(userName)) && u.Password.Equals(password));
            return count == 1;
        }

        public void LoginUser(string userName)
        {
            ChangeLogin(userName, 1);
        }

        private void ChangeLogin(string userName, int loginValue)
        {
            var user = UserDataAccess.GetUserByName(userName);
            if (user != null)
            {
                user.LoggedIn = loginValue;
                UserDataAccess.SaveUser(user);
            }
        }

        public void Logout(string userName)
        {
            ChangeLogin(userName, 0);
        }
    }
}