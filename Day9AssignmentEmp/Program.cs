﻿namespace Day9AssignmentEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welecome to employee wages");
            Console.WriteLine("chooes number\n1.EMp present absent\n2.Daily wages");
            int opt=Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    EmpPresentAbsent.EmployeeAttendance();
                    break;
                    case 2:
                    DailyWages.CalculateDailyWage();
                    break;
            }
        }
    }
}