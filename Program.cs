using System;
using System.Collections.Generic;

namespace empWageComputation
{
    class Program
    {
        private static int FULL_TIME = 8;
        private static int PART_TIME = 4;
        private static int WAGE_PER_HOUR = 20;
        
        

        static void Main(string[] args)
        {
            int employeeMonthlyWage;
            var dailyWage = new Dictionary<string, int>();

            Console.WriteLine("*** Welcome to Employee Wage Computation ***");
            Employee emp = new Employee(FULL_TIME,PART_TIME,WAGE_PER_HOUR); // employee instance

            employeeMonthlyWage = emp.monthlyWage(dailyWage);

            Console.WriteLine(employeeMonthlyWage);
        }

    }
}
 