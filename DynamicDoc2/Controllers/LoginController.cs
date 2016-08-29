using DynamicDoc2.DataAccess;
using DynamicDoc2.Models;
using DynamicDoc2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicDoc2.Controllers
{
    public class LoginController : Controller
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
                return Json(new { isSuccess = false, error = "Invalid arguments."}, JsonRequestBehavior.AllowGet);

            var checkSuccess = LoginService.CheckLogin(userName, password);
            User user = null;
            if(checkSuccess)
                user = UserService.GetUserByName(userName);                

            return Json(new { isSuccess = checkSuccess, user = user}, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Logout(string userName)
        {
            LoginService.Logout(userName);

            return Json(new { isSuccess = true }, JsonRequestBehavior.AllowGet);
        }
    }
}