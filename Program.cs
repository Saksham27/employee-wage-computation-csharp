using System;

namespace empWageComputation
{
    class Program
    {
      
        private static int employeeMonthlyWage;

        static void Main(string[] args)
        {

            Console.WriteLine("*** Welcome to Employee Wage Computation ***");
            Employee emp = new Employee();

            employeeMonthlyWage = emp.monthlyWage();

        }

    }
}
 