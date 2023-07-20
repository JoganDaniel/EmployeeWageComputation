using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeeWage
    {
        const int Full_Day_Hr = 8, Part_Day_Hr = 4, Is_Full_Time = 0, Is_Part_Time = 1;
        int totalEmpWage = 0, empHrs = 0,wageperhr,totalWorkingdays,totalworkinghrs;
        string companyname;
        Random random = new Random();


        public EmployeeeWage(string companyname, int wageperhr,int totalWorkingdays,int totalworkinghrs)
        {
            this.companyname = companyname;
            this.wageperhr = wageperhr;
            this.totalWorkingdays = totalWorkingdays;
            this.totalworkinghrs = totalworkinghrs;
        }
        public void GenerateAttendance()
        {
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
            for (int i = 0; i < totalWorkingdays && empHrs<totalworkinghrs; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Full_Time:
                        empHrs += Full_Day_Hr;
                        break;
                    case Is_Part_Time:
                        empHrs += Part_Day_Hr;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
            }
            totalEmpWage = wageperhr * empHrs;
            Console.WriteLine("Wage of " +companyname+" employee is " + totalEmpWage);
        }
        public void CompanyWage()
        {
            Console.WriteLine(this.companyname+" wage is "+this.totalEmpWage);
        }

        
    }
}
