using System;
using System.Collections.Generic;
using System.Text;

namespace MtpApp.Core
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"FirstName : {FirstName} LastName : {LastName} " );
        }
    }
}
