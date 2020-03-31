using System;
using System.Collections.Generic;
using System.Text;

namespace empWageComputation
{
    class Employee
    {
        private int PRESENT = 0;

        // Method to check if employee is present or not
        public bool employeeAttendance()
        {
            Random r = new Random();
            return r.Next(0, 2) == PRESENT ? true : false;
        }

        // Method to calculate employee wage for 1 day
        public int dailyEmployeeWage(int wage, int workingHours)
        {
            return wage * workingHours;
        }
    }
}
