using System;

namespace Mod_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 7 * (x * x) - 3 * x + 6;
            Console.WriteLine("y = " + y);
        }
    }
}
