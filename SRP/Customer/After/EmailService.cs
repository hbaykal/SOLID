using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Customer.After
{
    public interface IEmailService
    {
        void SendEmail(Customer customer);
    }
    public class EmailService : IEmailService
    {
        public void SendEmail(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
