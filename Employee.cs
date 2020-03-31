using System;
using System.Collections.Generic;
using System.Text;

namespace empWageComputation
{
    class Employee
    {
        // constants
        private int MONTHLY_WORKING_DAYS = 20;
        private int FULL_DAY_HOUR;
        private int PART_TIME_HOUR;
        private int WAGE_PER_HOUR;
        private int PRESENT = 0;
        private int NO_WAGE = 0;
        private int MONTHLY_MAX_WORKING_HOURS = 100;
        private int DAYS_IN_MONTH = 30;

        // variables
        private int empType;
        private int workHours;
        private int wageForADay;
        private bool isEmployeePresent;
        private int workingHoursForMonth = 0;
        private int days = 0;

        // constructor
        public Employee(int fullTime, int partTime, int wagePerHour)
        {
            this.FULL_DAY_HOUR = fullTime;
            this.PART_TIME_HOUR = partTime;
            this.WAGE_PER_HOUR = wagePerHour;
        }

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

        // Method to get working hours for a day
        public int getworkingHoursForDay(int workingHoursForMonth)
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

            if ((MONTHLY_MAX_WORKING_HOURS - workingHoursForMonth) < FULL_DAY_HOUR)
            {
                workHours = PART_TIME_HOUR;
            }

            return workHours;
        }

        // Method to calculate monthly wage for a employee
        public int monthlyWage()
        {

            int employeeMonthlyWage = 0;
            int daysWorkedInMonth = 0;

            // calculating wage for max of 100 hours or 20 days of work done or 30 days aka month gets over
            while ( daysWorkedInMonth < MONTHLY_WORKING_DAYS && workingHoursForMonth < MONTHLY_MAX_WORKING_HOURS && days < DAYS_IN_MONTH)
            {
                isEmployeePresent = this.employeeAttendance();

                if (isEmployeePresent == true) // cheking if employee is present or not
                {
          
                    workHours = getworkingHoursForDay(workingHoursForMonth); //getting working hours for day according to full time or part time employee

                    wageForADay = this.dailyEmployeeWage(WAGE_PER_HOUR, workHours);  // Daily wage

                    daysWorkedInMonth++; // incrementing worked day by 1

                    workingHoursForMonth += workHours; // adding hours worked in day to monthly worked hours
                }
                else
                {
                    wageForADay = NO_WAGE;  // Daily wage
                }

                days++; // increasing a day

                employeeMonthlyWage += wageForADay;  // Caclulating monthly wage
               
            }
            return employeeMonthlyWage;
        }
    }
}
