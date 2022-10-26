using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    public class program
    {
        public static void Main(string[] args)
        {
            int s1, s2, s3, s4, s5, high=0;

            Console.WriteLine("please enter the average marks of student1");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the average marks of student2");
             s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the average marks of student3");
             s3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the average marks of student4");
             s4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the average marks of student5");
             s5 = Convert.ToInt32(Console.ReadLine());

            if(s1>s2 && s1>s3 && s1>s4 && s1 > s5) 
            {
                high = s1;
               
            }
            else if (s2 > s1 && s2 > s3 && s2 > s4 && s2 > s5)
            {
                high = s2;
            }
            else if (s3 > s2 && s3 > s1 && s3 > s4 && s3 > s5)
            {
                high = s3;
            }
            else if (s4 > s2 && s4 > s3 && s4 > s1 && s4 > s5)
            {
                high = s4;
            }
            else if  (s5 > s2 && s5 > s3 && s5 > s4 && s5 > s1)
             {
                high= s5;
             }
            else
            {
                Console.WriteLine("Not available");
            }
            Console.WriteLine("highest is {0}",high);
            Console.ReadLine();
            
        }


    }
}