using System;

namespace empWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEmployeePresent;
            Console.WriteLine("*** Welcome to Employee Wage Computation ***");
            Employee emp = new Employee();
            isEmployeePresent = emp.employeeAttendance();
        }
    }
}
