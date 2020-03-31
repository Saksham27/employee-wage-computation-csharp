using System;
using System.Collections.Generic;
using System.Text;

namespace empWageComputation
{
    class Employee
    {
        private int PRESENT = 0;

        public bool employeeAttendance()
        {
            Random r = new Random();
            return r.Next(0, 1) == 0 ? true : false;
        }
    }
}
