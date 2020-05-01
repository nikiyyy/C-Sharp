using System;

//1 зад: Да се изчисли периметъра на окръжност като се прави проверка за коректност на въведеният радиус r= дали не е отицателно число.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input a radius");

                int perimeter = Int32.Parse(Console.ReadLine());

                if (perimeter > 0)
                    Console.WriteLine($"{2 * perimeter * 3.1415}");
                else
                    Console.WriteLine("you have entered a negative number");
                Console.ReadLine();
            }
            catch {
                Console.WriteLine("you have entered an invalid input");
                Console.ReadLine();
            }
        }
    }
}
