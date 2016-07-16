using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDoc2.DataAccess
{
    public class UserDataAccess : NhibernateDataProvider
    {
        public User GetUserById(int userId)
        {
            var session = GetSession();
            return session.Get<User>(userId);
        }

        public User GetUserByName(string userName)
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<User>();
            User user;
            if (userName.Contains("@"))
                user = criteria.List<User>().FirstOrDefault<User>(u => u.EmailId.Equals(userName));
            else
                user = criteria.List<User>().FirstOrDefault<User>(u => u.Name.Equals(userName));

            return user;
        }

        public void SaveUser(User user)
        {
            var session = GetSession();
            session.BeginTransaction();
            session.SaveOrUpdate(user);
            session.Transaction.Commit();
        }

        public void SaveUsers(List<User> users)
        {
            var session = GetSession();
            session.BeginTransaction();
            users.ForEach(u => session.SaveOrUpdate(u));
            session.Transaction.Commit();
        }

        public List<User> GetAllUsers()
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<User>();
            var l = criteria.List<User>().Where<User>(u => u.Name != null).ToList();

            return l;
        }
    }
}