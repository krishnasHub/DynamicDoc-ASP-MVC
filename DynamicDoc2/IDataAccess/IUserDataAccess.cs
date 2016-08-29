using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IDataAccess
{
    public interface IUserDataAccess
    {
        User GetUserById(int userId);
        User GetUserByName(string userName);
        void SaveUser(User user);
        void SaveUsers(List<User> users);
        List<User> GetAllUsers();
    }
}
