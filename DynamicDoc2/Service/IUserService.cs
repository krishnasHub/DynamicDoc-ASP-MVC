using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.Service
{
    public interface IUserService
    {
        User GetUserById(int userId);

        User GetUserByName(string userName);

        void SaveUser(User user);

        List<User> GetAllUsers();
    }
}
