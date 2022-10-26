using System;



namespace c_sharpA1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int add, sub, mul, div;
            Console.WriteLine("enter n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n2");
            n2 = Convert.ToInt32(Console.ReadLine());


            add = n1 + n2;
            sub = n1 - n2;
            mul = n1 * n2;
            div = n1 / n2;
            Console.WriteLine("results:");
            Console.WriteLine("Addition-{0}", add);
            Console.WriteLine("Subtraction-{0}", sub);
            Console.WriteLine("Multiplication-{0}", mul);
            Console.WriteLine("division-{0}", div);
            Console.ReadLine();



        }
    }
}
