using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_L7_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Add / Minus / Multiply / Divide");
            string calc = (Console.ReadLine());

            switch (calc)
            {
                case ("Add"):
                    Add();
                    break;
                case ("Minus"):
                    Minus();
                    break;
                case ("Multiply"):
                    Multiply();
                    break;
                case ("Divide"):
                    Divide();
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;


            }
        }
        static void Add()
        {
            int numA;
            int numB;
            Console.WriteLine("Please enter two numbers");
            numA = int.Parse(Console.ReadLine());
            numB = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of those numbers is " + (numA + numB));
        }

        static void Minus()
        {
            int numA;
            int numB;
            Console.WriteLine("Please enter two numbers");
            numA = int.Parse(Console.ReadLine());
            numB = int.Parse(Console.ReadLine());

            Console.WriteLine("The minus of those numbers is " + (numA - numB));
        }

        static void Multiply()
        {
            int numA;
            int numB;
            Console.WriteLine("Please enter two numbers");
            numA = int.Parse(Console.ReadLine());
            numB = int.Parse(Console.ReadLine());

            Console.WriteLine("The multiply of those numbers is " + (numA * numB));
        }

        static void Divide()
        {
            int numA;
            int numB;
            Console.WriteLine("Please enter two numbers");
            numA = int.Parse(Console.ReadLine());
            numB = int.Parse(Console.ReadLine());

            Console.WriteLine("The divation of those numbers is " + (numA / numB));
        }
    }
}