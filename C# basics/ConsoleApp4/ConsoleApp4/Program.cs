using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4 Зад: Да се напише програма, която да принтира първите 10 числа с последователност 2, -3, 4, -5, 6, -7, ...

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {    
            for (int i = 0; i <= 10; i++) {
                if (i%2==0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(i*-1);
            }
            Console.ReadKey();
        }
    }
}
