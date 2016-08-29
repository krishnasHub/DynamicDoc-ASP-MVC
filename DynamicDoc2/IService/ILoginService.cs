using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IService
{
    public interface ILoginService
    {
        bool CheckLogin(string userName, string password);

        void Logout(string userName);
    }
}
