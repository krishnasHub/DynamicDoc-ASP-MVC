using DynamicDoc2.DataAccess;
using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicDoc2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public JsonResult Login(string userName, string password)
        {
            if (userName == null || password == null)
                return Json(new { IsSuccess = false, Error = "Invalid arguments."}, JsonRequestBehavior.AllowGet);

            var loginDao = new LoginDataAccess();
            var userDao = new UserDataAccess();

            //var user = obj.getEmployeeById(1);
            var checkSuccess = loginDao.CheckLogin(userName, password);
            User user = null;
            if(checkSuccess)
            {
                user = userDao.GetUserByName(userName);
                if (user == null)                
                    user = userDao.GetUserByEmail(userName);                

                if (user.LoggedIn == 1)
                    return Json(new { IsSuccess = true, User = user, Warning = "Already Logged in!"}, JsonRequestBehavior.AllowGet);
                user.LoggedIn = 1;
                userDao.SaveUser(user);
            }

            return Json(new { IsSuccess = checkSuccess, User = user}, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Logout(string userName)
        {
            var loginDao = new LoginDataAccess();
            loginDao.Logout(userName);

            return Json(new { IsSuccess = true }, JsonRequestBehavior.AllowGet);
        }
    }
}