using EmployeeWageComputation;
using System;
namespace EmployeeWageCoomputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            EmployeeeWage appleWage = new EmployeeeWage("apple", 20, 30, 8); 
            appleWage.CalculateDailyWage();
            EmployeeeWage tvsWage =  new EmployeeeWage("tvs",35,20,10);
            tvsWage.CalculateDailyWage();
        }
    }
}