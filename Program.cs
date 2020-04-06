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

            // data structure to store daily wage corresponding toe each day
            Dictionary<string, int> dailyWage = new Dictionary<string, int>();      
            
            Console.WriteLine("*** Welcome to Employee Wage Computation ***");

            // employee instance            
            Employee employee = new Employee(FULL_TIME,PART_TIME,WAGE_PER_HOUR);

            // calculating the total monthly wage for employee instance
            employeeMonthlyWage = employee.MonthlyWage(dailyWage);

            // printing the daily wage
            foreach (var item in dailyWage)     
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
          
            Console.WriteLine($"Total Monthly Wage : {employeeMonthlyWage}");   
        }

    }
}
 