using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MtpApp.Core;
namespace MtpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input 1 :");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Input 2 :");
            //string s2 = Console.ReadLine();

            //int a = Convert.ToInt32(s1);
            //int b = Convert.ToInt32(s2);

            //Calculator calculator = new Calculator();
            //int c = calculator.Add(a,b);

            //string msg = $"Your Ans : {a} + {b} = {c}";
            //Console.WriteLine(msg);
            //Console.ReadLine();
            //test
            //int i = 0;
            //Calculator calculator1 = new Calculator(true);

            //Calculator calculator2 = new Calculator();
            //calculator2.SetAbs(true);
            //while (true)
            //{

            //    string s1 = Console.ReadLine();

            //    if(int.TryParse(s1,out int a))
            //    {
            //        if (i%2 == 0)
            //        {

            //            calculator1.Input(a);
            //        }
            //        else
            //        {
            //            calculator2.Input(a);
            //        }

            //    }
            //    else
            //    {
            //        break;
            //    }
            //    i++;
            //}

            //int c = calculator1.GetResult();
            //int d = calculator2.GetResult();

            //string input1 = String.Join(",",calculator1.GetHistory());
            //string input2 = String.Join(",", calculator2.GetHistory());
            //string msg = $"Your Ans Set 1: {c} , Your Ans Set 2: {d}";
            //Console.WriteLine(input1);
            //Console.WriteLine(input2);
            //Console.WriteLine(msg);
            //Console.ReadLine();

            //User user = new User("Punyawat","Kanfak");

            //user.FirstName = "Aun";
            //Console.WriteLine(user.FirstName);
            //Console.WriteLine(user.LastName);
            //Console.WriteLine(user.FullName);
            //double a = Math.PI;
            //Console.WriteLine(a);

            //CustomerService customerservice = new CustomerService();
            //IEnumerable<Customer> customers = customerservice.GetAllCustomers();
            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //// string msg = AunService.GetServiceName();
            //// Console.WriteLine(msg);
            //Customer customer = new Customer();
            //customer.FirstName = "Pun";
            //customer.LastName = "Yawat";
            //customer.Id = 0;
            //customer.Address = "Phitlok";
            //customerservice.CreateCustomer(customer);

            //PrintCustomer();
            ////Add
            //Customer customer2 = new Customer() { FirstName = "Aun", LastName = "Kanfak", Address = "TH" };
            //customerservice.CreateCustomer(customer2);

            //PrintCustomer();
            ////Find
            //Customer customer3 = customerservice.FindCustomerById(5);

            //if( customer3 == null)
            //{
            //    Console.WriteLine($" No Customer !!");

            //}
            //else {
            //    Console.WriteLine($"Name :  { customer3.FirstName} { customer3.LastName} ID: {customer3.Id} Address : {customer3.Address}");

            //}


            ////update
            //Customer customer4 = new Customer { FirstName = "AunNaja", LastName = "JubJub",Id = 3, Address = "THhh" };
            //customerservice.UpdateCustomer(customer4);

            //PrintCustomer();

            ////delete

            //customerservice.DeleteCustomer(4);

            //PrintCustomer();


            //MTPUser mTPUser = new MTPUser();
            // Customer customer = (Customer)mTPUser;
            //mTPUser.Print();

            //CustomerService customerService = new CustomerService();
            //customerService.CreateCustomer(mTPUser);

            CustomerService customerService = new CustomerService();
            IPrinter printer = new Printer(customerService);
            printer.StartUI();

            //Console.ReadLine();
        }


        public static void PrintCustomer()
        {
            CustomerService customerservice = new CustomerService();
            IEnumerable<Customer> customers2 = customerservice.GetAllCustomers();
            foreach (var item in customers2)
            {
                Console.WriteLine($"Name :  { item.FirstName} { item.LastName} ID : {item.Id} Address {item.Address} ");
            }


            Console.ReadLine();
        }
       
    }


}
