using System;
using System.Collections.Generic;

namespace empWageComputation
{

    class Employee
    {
        /// <summary>
        /// constants same for every employee
        /// </summary>
        const int MONTHLY_WORKING_DAYS = 20;
        const int PRESENT = 0;
        const int NO_WAGE = 0;
        const int MONTHLY_MAX_WORKING_HOURS = 100;
        const int DAYS_IN_MONTH = 30;

        /// <summary>
        /// variables specific for each employe
        /// </summary>
        int fullDayHour;
        int partTimeHour;
        int wagePerHour;
        int empType;
        int workHours;
        int wageForADay;
        bool employeePresent;
        int workingHoursForMonth = 0;
        int days = 0;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="fullTime"> full time working hour </param>
        /// <param name="partTime"> part time working hour </param>
        /// <param name="wagePerHour"> employee wage per hour </param>
        public Employee(int fullTime, int partTime, int wagePerHour)
        {
            this.fullDayHour = fullTime;
            this.partTimeHour = partTime;
            this.wagePerHour = wagePerHour;
        }

        /// <summary>
        /// Method to check if employee is present or not
        /// </summary>
        /// <returns></returns>
        public bool EmployeeAttendance()
        {
            Random randomNumber = new Random();
            return randomNumber.Next(0, 2) == PRESENT ? true : false;
        }

        /// <summary>
        /// Method to calculate employee wage for 1 day
        /// </summary>
        /// <param name="wage"> wage per hour </param>
        /// <param name="workingHours"> how many hours employee worked at that day </param>
        /// <returns></returns>
        public int DailyEmployeeWage(int wage, int workingHours)
        {
            return wage * workingHours;
        }

        /// <summary>
        /// Method to get working hours for a day
        /// </summary>
        /// <param name="workingHoursForMonth"> how many hours employee has already worked in month </param>
        /// <returns></returns>
        public int GetworkingHoursForDay(int workingHoursForMonth)
        {
            Random randomNum = new Random();
            empType = randomNum.Next(0, 2);

            // cheking employee type part time or full time
            switch (empType) 
            {
                case 0:
                    workHours = fullDayHour;
                    break;
                case 1:
                    workHours = partTimeHour;
                    break;
                default:
                    break;
            }

            // situation when employee has worked for 96 hours, and comes next day for full day
            if ((MONTHLY_MAX_WORKING_HOURS - workingHoursForMonth) < fullDayHour)  
            {
                workHours = partTimeHour;
            }
            return workHours;
        }

        /// <summary>
        /// method to calculate work hours for day and month and wage for the day
        /// </summary>
        /// <param name="daysWorkedInMonth"> no of days employee has already worked in month </param>
        public void CalculateWorkingHoursAndWage(int daysWorkedInMonth)
        {
            // cheking if employee is present or not
            if (employeePresent == true)      
            {
                //getting working hours for day according to full time or part time employee
                workHours = GetworkingHoursForDay(workingHoursForMonth);

                // Daily wage
                wageForADay = this.DailyEmployeeWage(wagePerHour, workHours);

                // incrementing worked day by 1
                daysWorkedInMonth++;

                // adding hours worked in day to monthly worked hours
                workingHoursForMonth += workHours;      
            }
            else
            {
                wageForADay = NO_WAGE;      // Daily wage
            }
        }

        /// <summary>
        /// Method to calculate monthly wage for a employee
        /// </summary>
        /// <param name="dictionary"> data structure to store day and its corresponding wage </param>
        /// <returns></returns>
        public int MonthlyWage(Dictionary<string, int> dictionary)
        {
            int employeeMonthlyWage = 0;
            int daysWorkedInMonth = 0;

            // calculating wage for max of 100 hours or 20 days of work done or 30 days aka month gets over
            while ( daysWorkedInMonth < MONTHLY_WORKING_DAYS && workingHoursForMonth < MONTHLY_MAX_WORKING_HOURS && days < DAYS_IN_MONTH)   
            {
                employeePresent = this.EmployeeAttendance();

                CalculateWorkingHoursAndWage(daysWorkedInMonth);

                days++; 
                dictionary[$"Day {days}"] = wageForADay;

                // Caclulating monthly wage
                employeeMonthlyWage += wageForADay;     
               
            }
            return employeeMonthlyWage;
        }
    }
}
