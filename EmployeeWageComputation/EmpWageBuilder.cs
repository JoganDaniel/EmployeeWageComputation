using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder
    {
        EmployeeeWage[] companyArray = new EmployeeeWage[10];
        int numofcompany = 0;

        public void AddToCompanyArray(string companyname, int wageperhr, int totalWorkingdays, int totalworkinghrs)
        {
            companyArray[numofcompany] = new EmployeeeWage(companyname, wageperhr, totalWorkingdays, totalworkinghrs);
            numofcompany++;
        }
        public void CalculateWage()
        {
            for(int i = 0;i<numofcompany;i++)
            {
                EmployeeeWage empwage = companyArray[i];
                empwage.CalculateDailyWage();
            }
        }
    }
}
