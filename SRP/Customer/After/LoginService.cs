using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Customer.After
{
    public interface ILoginService
    {
        Customer Login(string userName, string password);
        bool Logout();
    }
    public class LoginService : ILoginService
    {
        public Customer Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }
    }
}
