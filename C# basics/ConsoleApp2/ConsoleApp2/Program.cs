using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2 зад: Да се въвеждат две числа. Да се изведе по-голямото от тях.

namespace ConsoleApp2
{
    class Program
    {

        static int bigger(int a, int b) {
            if (a > b)
                return a;
            else
                return b;
        }


        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("input number a");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("input number b");
                int b = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"{ bigger(a, b)}");

            }
            catch
            {
                Console.WriteLine("invalid input");
            }
            finally
            { 
                Console.ReadLine();
            }
        }
    }
}
