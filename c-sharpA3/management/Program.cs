using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Employee
    {
        public static void Main(string[] args)
        { }

        private int EmpNo;
        public string EmpName { get; }
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }


        public Employee(int empNo, string empName, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            Salary = salary;
        }
        public virtual void CalculateSalary()
        {
            double salary = Salary;
            if (salary < 5000)
            {

                HRA = 0.1 * salary;
                TA = 0.05 * salary;
                DA = 0.15 * salary;
            }
            else if (salary < 10000)
            {

                HRA = 0.15 * salary;
                TA = 0.1 * salary;
                DA = 0.2 * salary;
            }
            else if (salary < 15000)
            {

                HRA = 0.2 * salary;
                TA = 0.15 * salary;
                DA = 0.25 * salary;
            }
            else if (salary < 20000)
            {

                HRA = 0.25 * salary;
                TA = 0.2 * salary;
                DA = 0.30 * salary;
            }
            else if (salary >= 20000)
            {

                HRA = 0.3 * salary;
                TA = 0.25 * salary;
                DA = 0.35 * salary;
            }

            GrossSalary = Salary + HRA + TA + DA;
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
        }
        public string ShowDetails() => ($"\t Employee Number: {EmpNo}\n\t Employee Name: {EmpName}\n\t Gross Salary: {GrossSalary}\n\t Net Salary: {NetSalary}");
    }



    namespace Task1
    {
        class Manager : Employee
        {
            private double PetrolAllowance;
            private double FoodAllowance;
            private double OtherAllowances;
            public Manager(int empNo, string empName, double salary) : base(empNo, empName, salary)
            {
                PetrolAllowance = 0.08 * salary;
                FoodAllowance = 0.13 * salary;
                OtherAllowances = 0.03 * salary;

            }
            public override void CalculateSalary()
            {
                base.CalculateSalary();
                GrossSalary = GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
                NetSalary = NetSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
            }
        }
    }
    namespace Task1
    {
        class MarketingExecutive : Employee
        {
            private double KilometerTravel;
            private double TourAllowance;
            private double TelephoneAllowance = 1000;
            public MarketingExecutive(int empNo, string empName, double salary, double kilometerTravel) : base(empNo, empName, salary)
            {
                KilometerTravel = kilometerTravel;
                TourAllowance = 5 * KilometerTravel;
            }

            public override void CalculateSalary()
            {
                base.CalculateSalary();
                GrossSalary = GrossSalary + TourAllowance + TelephoneAllowance;
                NetSalary = NetSalary + TourAllowance + TelephoneAllowance;
            }
        }
    }


    namespace Task1
    {
        interface IPrintable
        {
            string ShowDetails();
        }
    }
}