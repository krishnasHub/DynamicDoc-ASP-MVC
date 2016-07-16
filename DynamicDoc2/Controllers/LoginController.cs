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
                return Json(new { isSuccess = false, error = "Invalid arguments."}, JsonRequestBehavior.AllowGet);

            var loginDao = new LoginDataAccess();
            

            //var user = obj.getEmployeeById(1);
            var checkSuccess = loginDao.CheckLogin(userName, password);
            User user = null;
            if(checkSuccess)
            {
                var userDao = new UserDataAccess();
                user = userDao.GetUserByName(userName);

                if (user.LoggedIn == 1)
                    return Json(new { isSuccess = true, user = user, warning = "User already logged in." }, JsonRequestBehavior.AllowGet);
                else
                    loginDao.LoginUser(user.Name);
            }

            return Json(new { isSuccess = checkSuccess, user = user}, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Logout(string userName)
        {
            var loginDao = new LoginDataAccess();
            loginDao.Logout(userName);

            return Json(new { isSuccess = true }, JsonRequestBehavior.AllowGet);
        }
    }
}