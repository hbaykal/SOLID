using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Customer.After
{
    public class CustomerService
    {
        public void CreateCustomer(Customer customer) { }
        public void DeleteCustomer(int customerId) { }
        public Customer Get(int Id) { return new Customer(); }
    }
}
