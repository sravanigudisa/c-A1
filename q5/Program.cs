using System;

namespace q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double c, area, pi = 3.14;
            Console.WriteLine("enter radius");
            r = Convert.ToInt32(Console.ReadLine());
            area = pi * r * r;
            c = 2 * pi * r;
            Console.WriteLine("area of circle {0}",area);
            Console.WriteLine("circumference of circle {0}",c);
            Console.ReadLine();
        }
    }
}
