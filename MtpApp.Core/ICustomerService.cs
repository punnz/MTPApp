using System.Collections.Generic;

namespace MtpApp.Core
{
    public interface ICustomerService
    {
        int Count();
        Customer CreateCustomer(Customer customer);
        Customer DeleteCustomer(int id);
        Customer FindCustomerById(int id);
        IEnumerable<Customer> GetAllCustomers();
        Customer NewCustomer(string firsname, string lastname);
        Customer UpdateCustomer(Customer customerUpdate);
    }
}