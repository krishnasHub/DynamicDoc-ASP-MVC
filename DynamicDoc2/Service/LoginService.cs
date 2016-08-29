
using DynamicDoc2.IService;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.Service
{
    public class LoginService : ILoginService
    {
        private ILoginDataAccess LoginDataAccess;

        public LoginService(ILoginDataAccess LoginDataAccess)
        {
            this.LoginDataAccess = LoginDataAccess;
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