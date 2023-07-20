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
            EmployeeeWage appleWage = new EmployeeeWage("apple",200,25,10);
            appleWage.CalculateDailyWage();
            EmployeeeWage tvsWage = new EmployeeeWage("tvs", 100, 28, 8);
            tvsWage.CalculateDailyWage();
        }
    }
}