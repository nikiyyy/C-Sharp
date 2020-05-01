using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5 зад: Да се напише програма, която да принтира числата от 1 до 1000, като след 10-то число да изписва числата на нов ред

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i <= 1000; i++)
                {

                    if (i % 10 == 0)
                        Console.WriteLine(i);

                    else Console.Write($"{i} ");
                }
            }
            finally {
                Console.ReadLine();

            }
        }
    }
}
