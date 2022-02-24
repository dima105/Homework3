using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 14;
            y = 1;
            z = 5;
            x += y - x++ * z;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);
            z = --x - y * 5;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);
            y /= x + 5 % z;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);
            z = x++ + y * 5;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);
            x = y - x++ * z;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);


        }
    }
}
