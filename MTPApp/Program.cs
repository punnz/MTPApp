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
            int i = 0;
            Calculator calculator1 = new Calculator(true);

            Calculator calculator2 = new Calculator();
            calculator2.SetAbs(true);
            while (true)
            {

                string s1 = Console.ReadLine();
               
                if(int.TryParse(s1,out int a))
                {
                    if (i%2 == 0)
                    {
                    
                        calculator1.Input(a);
                    }
                    else
                    {
                        calculator2.Input(a);
                    }
                    
                }
                else
                {
                    break;
                }
                i++;
            }

            int c = calculator1.GetResult();
            int d = calculator2.GetResult();

            string input1 = String.Join(",",calculator1.GetHistory());
            string input2 = String.Join(",", calculator2.GetHistory());
            string msg = $"Your Ans Set 1: {c} , Your Ans Set 2: {d}";
            Console.WriteLine(input1);
            Console.WriteLine(input2);
            Console.WriteLine(msg);
            Console.ReadLine();
        }

        static string PrintResult(List<int> l)
        {
            string resultmsg = string.Empty;

            foreach (var item in l)
            {
                
            }

            return resultmsg;
        }
    }


}
