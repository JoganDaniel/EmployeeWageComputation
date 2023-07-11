using EmployeeWageComputation;
using System;
namespace EmployeeWageCoomputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            EmployeeeWage employeeeWage = new EmployeeeWage();
            employeeeWage.CalculateDailyWage();
        }
    }
}