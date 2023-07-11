using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeeWage
    {
        int Wage_Per_Hr = 20; int Full_Day_Hr = 8;
        public void GenerateAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
        public void CalculateDailyWage()
        {
            int dailywage = Wage_Per_Hr * Full_Day_Hr;
            Console.WriteLine("Daily wage of employee is " + dailywage);
        }
    }
}
