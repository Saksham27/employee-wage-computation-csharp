using System;
using System.Collections.Generic;

namespace empWageComputation
{
    class Program
    {
        /// <summary>
        /// constants specific to any company's employee, full day hours, part time hours and per hour wage
        /// </summary>
        const int FULL_TIME = 8;
        const int PART_TIME = 4;
        const int WAGE_PER_HOUR = 20;
        
        /// <summary>
        /// main method, program execution begins here
        /// </summary>
        /// <param name="args"> no parameters </param>
        static void Main(string[] args)
        {
            int employeeMonthlyWage;
            Dictionary<string, int> dailyWage = new Dictionary<string, int>();      // data structure to store daily wage corresponding toe each day
            
            Console.WriteLine("*** Welcome to Employee Wage Computation ***");
                        
            Employee employee = new Employee(FULL_TIME,PART_TIME,WAGE_PER_HOUR);    // employee instance

            employeeMonthlyWage = employee.monthlyWage(dailyWage);  // calculating the total monthly wage for employee instance
            
            foreach (var item in dailyWage)     // printing the daily wage
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
          
            Console.WriteLine($"Total Monthly Wage : {employeeMonthlyWage}");   // prinitng the total monthly wage
        }

    }
}
 