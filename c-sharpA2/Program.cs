using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class program 
    {
        public static void Main(string[] args)
        {
            EmpDetails emp = new EmpDetails();

            Console.WriteLine("EMPLOYEE SALARY DETAILS");
            Console.WriteLine("Please Enter The Employee Number : ");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            if (emp.EmpNo <= 0)
            {
                Console.WriteLine("Employee Number Should be Greater Than 0  : ");
                Console.WriteLine("Please Enter The Employee Number : ");
                emp.EmpNo = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Please Enter The Employee Name : ");
            emp.EmpName = Console.ReadLine();
            if (emp.EmpName == "" || emp.EmpName == null)
            {
                Console.WriteLine("Employee Name Should Not be Empty: ");
                Console.WriteLine("Please Enter The Employee Name : ");
                emp.EmpName = Console.ReadLine();
            }

            Console.WriteLine("Please Enter The Employee Salary : ");
            emp.Salary = Convert.ToInt32(Console.ReadLine());
            if (emp.Salary <= 0)
            {
                Console.WriteLine("Employee Salary Should be Greater Than 0 : ");
                Console.WriteLine("Please Enter The Employee Salary : ");
                emp.Salary = Convert.ToInt32(Console.ReadLine());
            }

            if (emp.Salary <= 5000)
            {
                emp.HRA = 0.1;
                emp.TA = 0.05;
                emp.DA = 0.15;

            }
            if (emp.Salary > 5000 && emp.Salary <= 10000)
            {
                emp.HRA = 0.15;
                emp.TA = 0.1;
                emp.DA = 0.2;

            }
            if (emp.Salary > 10000 && emp.Salary <= 15000)
            {
                emp.HRA = 0.2;
                emp.TA = 0.15;
                emp.DA = 0.25;

            }
            if (emp.Salary > 15000 && emp.Salary < 20000)
            {
                emp.HRA = 0.25;
                emp.TA = 0.2;
                emp.DA = 0.3;

            }
            if (emp.Salary >= 20000)
            {
                emp.HRA = 0.3;
                emp.TA = 0.25;
                emp.DA = 0.35;

            }
            emp.GrossSalary = emp.Salary + emp.HRA + emp.TA + emp.DA;

            Console.Write("The Gross Salary of {0}  is  {1}  ", emp.EmpName, emp.GrossSalary);

            emp.PF = 0.1 * emp.GrossSalary;
            Console.Write("\nPF Amount for {0} is {1}", emp.EmpName, emp.PF);

            emp.TDS = 0.18 * emp.GrossSalary;
            Console.Write("\nTDS Amount for {0} is {1} ", emp.EmpName, emp.TDS);

            emp.NetSalary = emp.GrossSalary - (emp.PF + emp.TDS);
            Console.Write("\nNet Salary for {0} is {1} ", emp.EmpName, emp.NetSalary);
            Console.ReadLine();

        }

        public class EmpDetails
        {
            public int EmpNo { get; set; }
            public string EmpName { get; set; }
            public double Salary { get; set; }
            public double HRA { get; set; }
            public double TA { get; set; }
            public double DA { get; set; }
            public double PF { get; set; }
            public double TDS { get; set; }
            public double NetSalary { get; set; }
            public double GrossSalary { get; set; }
        }
    }
    internal class ShowData
    {
        public void Show()
        {
            program empd = new program();

            Console.WriteLine();
        }
    }
}