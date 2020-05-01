using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6 зад: Да се начертае на конзолата квадрат от N x N звездички
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("input size of box:");
                int size = Int32.Parse(Console.ReadLine());

                for (int i=1; i <= size; i++) {
                    for (int j=1; j <= size; j++) {
                        Console.Write(" *");
                    }
                    Console.WriteLine("");
                }
            }
            finally {
                Console.ReadKey();
            }

            
            
        }
    }
}
