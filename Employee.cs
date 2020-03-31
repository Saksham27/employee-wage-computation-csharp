using System;
using System.Collections.Generic;
using System.Text;

namespace empWageComputation
{
    class Employee
    {
        private int MONTHLY_WORKING_DAYS = 20;
        private int FULL_DAY_HOUR = 8;
        private int PART_TIME_HOUR = 4;
        private int PRESENT = 0;
        private int WAGE_PER_HOUR = 20;
        private int NO_WAGE = 0;
        private int MONTHLY_MAX_WORKING_HOURS = 100;

        private int empType;
        private int workHours;
        private int wageForADay;
        private bool isEmployeePresent;
        private int workingHoursForMonth = 0;

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


        // Method to calculate monthly wage for a employee
        public int monthlyWage()
        {

            int employeeMonthlyWage = 0;
            int daysWorkedInMonth = 0;
            while ( daysWorkedInMonth < MONTHLY_WORKING_DAYS && workingHoursForMonth < MONTHLY_MAX_WORKING_HOURS)
            {
                isEmployeePresent = this.employeeAttendance();
                if (isEmployeePresent == true)
                {
                    Random randomNum = new Random();
                    empType = randomNum.Next(0, 2);
                    switch (empType) // cheking employee type part time or full time
                    {
                        case 0:
                            workHours = FULL_DAY_HOUR;
                            break;
                        case 1:
                            workHours = PART_TIME_HOUR;
                            break;
                        default:
                            break;
                    }

                    if ( (MONTHLY_MAX_WORKING_HOURS - workingHoursForMonth) < FULL_DAY_HOUR)
                    {
                        workHours = PART_TIME_HOUR;
                    }

                    wageForADay = this.dailyEmployeeWage(WAGE_PER_HOUR, workHours);  // Daily wage
                    daysWorkedInMonth++;

                    workingHoursForMonth += workHours;
                }
                else
                {
                    wageForADay = NO_WAGE;  // Daily wage
                }

                employeeMonthlyWage += wageForADay;  // Caclulating monthly wage
               
            }
            return employeeMonthlyWage;
        }
    }
}
