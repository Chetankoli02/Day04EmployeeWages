using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class DailyWages
    {
        public void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HPUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 1;
            }
            empWage = empHrs * EMP_RATE_PER_HPUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
