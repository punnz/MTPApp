using System;
using System.Collections.Generic;
using System.Text;

namespace MtpApp.Core
{
    class CustomerServiceMock : ICustomerService
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public Customer CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer FindCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer NewCustomer(string firsname, string lastname)
        {
            throw new NotImplementedException();
        }

        public Customer UpdateCustomer(Customer customerUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
