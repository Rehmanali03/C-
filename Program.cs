using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a , b;
            Console.WriteLine("Enter Number One");
            a = Convert.ToInt32( Console.ReadLine());

            string op;
            Console.WriteLine("Enter Oprator");
            op = Console.ReadLine();

            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32( Console.ReadLine());

            switch (op)
            {
                case "+": 
                    Console.WriteLine(a + b);
                break;

                case "-":
                    Console.WriteLine(a - b);
                break;

                case "*":
                    Console.WriteLine(a * b);
                break;

                case "/":
                    Console.WriteLine(a / b);
                break;

               default:
                    Console.WriteLine("Enter Valid Oprator");
               break;

            }

            Console.Read();
        }
    }
}
//int i;
//for (i = 0; i <= 10; i++)
//{
//    Console.WriteLine("{0}*{1}={2}", a, i, a * i);
//}


//if(op == "+")
//{
//    Console.WriteLine(a + b);

//}
//  else if(op == "*")
//{
//    Console.WriteLine(a * b);
//}

//else if (op == "-")
//{
//    Console.WriteLine(a - b);
//}
//else if (op == "/")
//{
//    Console.WriteLine(a / b);
//}
//else
//{
//    Console.WriteLine("Enter Valid Oprator");
//}