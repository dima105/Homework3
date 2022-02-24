using System;

namespace RoundCone
{
    class Program
    {
        static void Main(string[] args)
        {
            double generatrix, radius;
            double results;
            double pi = Math.PI;
            Console.WriteLine("Введите длину радиуса");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину образующей ");
            generatrix = Convert.ToDouble(Console.ReadLine());
            results = pi * radius * (radius + generatrix);
            Console.WriteLine("Площадь полной поверхности круглого конуса=" + results);
        }
    }
}