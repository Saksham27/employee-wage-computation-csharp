using System;

namespace empWageComputation
{
    class Program
    {
        private static int FULL_TIME = 8;
        private static int PART_TIME = 4;
        private static int WAGE_PER_HOUR = 20;


        private static int employeeMonthlyWage;

        static void Main(string[] args)
        {

            Console.WriteLine("*** Welcome to Employee Wage Computation ***");
            Employee emp = new Employee(FULL_TIME,PART_TIME,WAGE_PER_HOUR);

            employeeMonthlyWage = emp.monthlyWage();

            Console.WriteLine(employeeMonthlyWage);
        }

    }
}
 