using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Customer.Before
{
    //buradaki class'ta CustomerService customer'ait işlem ler dışında Login,SendMail ve CreateOrder işlemlerini gerçekleştiriyor
    public class CustomerService
    {
        public void CreateCustomer(Customer customer) { }
        public void DeleteCustomer(int customerId) { }
        public void Login(string userName, string password) { }
        public void SendEmail(Customer customer) { }
        public void CreateOrder(Customer customer) { }

    }

    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
