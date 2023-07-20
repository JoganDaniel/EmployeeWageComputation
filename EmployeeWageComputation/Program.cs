using EmployeeWageComputation;
using System;
namespace EmployeeWageCoomputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            bool flag = true;
            EmpWageBuilder emp=new EmpWageBuilder();
            emp.AddToCompanyArray("apple", 200, 25, 10);
            emp.AddToCompanyArray("tvs", 100, 30, 8);
            emp.AddToCompanyArray("zoho", 150, 27, 9);
            emp.CalculateWage();
        }
    }
}