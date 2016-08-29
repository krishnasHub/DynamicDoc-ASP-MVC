using DynamicDoc2.Models;
using DynamicDoc2.IService;
using System.Web.Mvc;

namespace DynamicDoc2.Controllers
{
    public class LoginController : DynamicDocumentController
    {
        ILoginService LoginService;
        IUserService UserService;

        public LoginController(ILoginService LoginService, IUserService UserService)
        {
            this.LoginService = LoginService;
            this.UserService = UserService;
        }

        // GET: Login
        public JsonResult Login(string userName, string password)
        {
            if (userName == null || password == null)
                return GetDynamicJson(false, "Invalid arguments.");

            var checkSuccess = LoginService.CheckLogin(userName, password);
            User user = null;
            if(checkSuccess)
                user = UserService.GetUserByName(userName);

            return GetDynamicJson(new { user = user });
        }

        public JsonResult Logout(string userName)
        {
            LoginService.Logout(userName);

            return GetDynamicJson(true);
        }
    }
}