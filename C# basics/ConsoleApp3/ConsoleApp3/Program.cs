using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3 зад: Да се въвеждат две целочислени числа, да се реазменят техните стойности, ако първото е по-голямо от второто

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("a ="); 
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("b =");
                int b = Int32.Parse(Console.ReadLine());

                if (a > b) {
                    int temp = a;
                    a = b;
                    b = temp;
                }
                Console.WriteLine($"a = {a} and b = {b}");

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
