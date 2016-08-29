using DynamicDoc2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDoc2.Service
{
    public class LoginService : ILoginService
    {
        private LoginDataAccess LoginDataAccess;

        public LoginService()
        {
            LoginDataAccess = new LoginDataAccess();
        }

        public bool CheckLogin(string userName, string password)
        {
            var retVal = LoginDataAccess.CheckLogin(userName, password);
            if (retVal)
                LoginDataAccess.LoginUser(userName);

            return retVal;
        }

        public void Logout(string userName)
        {
            LoginDataAccess.Logout(userName);
        }
    }
}