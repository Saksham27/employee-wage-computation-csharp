using System;

namespace empWageComputation
{
    class Program
    {
        private static int WAGE_PER_HOUR = 20;
        private static int FULL_DAY_HOUR = 8;
        private static int PART_TIME_HOUR = 4;
        private static int NO_WAGE = 0;

        private static bool isEmployeePresent;
        private static int wageForADay;

        static void Main(string[] args)
        {

            Console.WriteLine("*** Welcome to Employee Wage Computation ***");
            Employee emp = new Employee();
            isEmployeePresent = emp.employeeAttendance();

            if (isEmployeePresent == true)
            {   
                wageForADay = emp.dailyEmployeeWage(WAGE_PER_HOUR, FULL_DAY_HOUR);
            }
            else
            {
                wageForADay = NO_WAGE;
            }
        }

    }
}
 