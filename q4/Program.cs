using System;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s;

            Console.WriteLine("enter the number for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number for b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("before swapping a={0} and b={1}", a, b);

            s = a;
            a = b;
            b = s;

            Console.WriteLine("after swapping a={0} and b={1}", a, b);
            Console.ReadLine();


        }
    }
}
