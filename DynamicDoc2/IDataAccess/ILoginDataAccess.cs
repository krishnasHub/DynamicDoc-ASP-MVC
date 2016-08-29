using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IDataAccess
{
    public interface ILoginDataAccess
    {
        bool CheckLogin(string userName, string password);
        void LoginUser(string userName);
        void Logout(string userName);
    }
}
