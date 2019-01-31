using System;
using System.Collections.Generic;
using System.Text;

namespace MtpApp.Core
{
    public class MTPUser:Customer
    {
        public string telNo { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Name : {FirstName} LastName : {LastName}");
        }
    }
}
