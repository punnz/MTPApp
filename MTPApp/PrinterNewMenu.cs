using MtpApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtpApp
{
    class PrinterNewMenu : IPrinter
    {
        private ICustomerService _customerService;

        public PrinterNewMenu(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        public void StartUI()
        {
            string[] menuItems = {
                "List All Customers Kub",
                "Add Customer Kub",
                "Delete Customer Kub",
                "Edit Customer Kub",
                "Exit Derrrrr"
            };

            var selection = ShowMenu(menuItems);

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        var customers = _customerService.GetAllCustomers();
                        ListCustomers(customers.ToList());
                        break;
                    case 2:
                        var firstName = AskQuestion("Firstname: ");
                        var lastName = AskQuestion("Lastname: ");
                        var address = AskQuestion("Address: ");

                        _customerService.CreateCustomer(new Customer()
                        {
                            Id = 0,
                            FirstName = firstName,
                            LastName = lastName,
                            Address = address
                        });

                        break;
                    case 3:
                        var idForDelete = PrintFindCustomeryId();
                        _customerService.DeleteCustomer(idForDelete);
                        break;
                    case 4:
                        var idForEdit = PrintFindCustomeryId();
                        var customerToEdit = _customerService.FindCustomerById(idForEdit);
                        Console.WriteLine("Updating " + customerToEdit.FirstName + " " + customerToEdit.LastName);
                        var newFirstName = AskQuestion("Firstname: ");
                        var newLastName = AskQuestion("Lastname: ");
                        var newAddress = AskQuestion("Address: ");
                        _customerService.UpdateCustomer(new Customer()
                        {
                            Id = idForEdit,
                            FirstName = newFirstName,
                            LastName = newLastName,
                            Address = newAddress
                        });
                        break;
                    default:
                        break;
                }
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("Bye bye!");

            Console.ReadLine();
        }



        int PrintFindCustomeryId()
        {
            Console.WriteLine("Insert Customer Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");
            }
            return id;
        }

        string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        void ListCustomers(List<Customer> customers)
        {
            Console.WriteLine("\nList of Customers");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Id: {customer.Id} Name: {customer.FirstName} " +
                                $"{customer.LastName} " +
                                $"Adress: {customer.Address}");
            }
            Console.WriteLine("\n");

        }

        /// <summary>
        /// Shows the menu.
        /// </summary>
        /// <returns>Menu Choice as int</returns>
        /// <param name="menuItems">Menu items.</param>
        int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select What you want to do:\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                //Console.WriteLine((i + 1) + ":" + menuItems[i]);
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 5)
            {
                Console.WriteLine("Please select a number between 1-5");
            }

            return selection;
        }
    }
}
