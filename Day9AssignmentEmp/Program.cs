﻿namespace Day9AssignmentEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welecome to employee wages");
            Console.WriteLine("chooes number\n1.EMp present absent\n2.Daily wages\n3.Part time wages\n4.using switch loop\n5. wages FOr Month\n6.using while loop\n7.Monthly emp wages\n8.wages for compnay\n9.emwges for miltiple company\n10.EmpWageBuilder\n11.ComputeEmpWage");
            int opt=Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    EmpPresentAbsent.EmployeeAttendance();
                    break;
                    case 2:
                    DailyWages.CalculateDailyWage();
                    break;
                case 3:
                    partTimeW.CalculatePercentage();
                        break;
                case 4:
                    SwitchLoop.CalculateWage();
                    break ;
                    case 5:
                    WagesForMonth.CalculateWageForMonth();
                    break ;
                case 6:
                    WhileLoop.CalculateWage();
                    break;
                case 7:
                    EmpWagesMonthly.CalculateEmpWages();
                    break;
                case 8:
                    UsingMultipaleCompany.ComputeWaageForMultipleCompany("TATA",20,20,100);
                    UsingMultipaleCompany.ComputeWaageForMultipleCompany("BMW", 20, 20, 100);
                    UsingMultipaleCompany.ComputeWaageForMultipleCompany("TCS",20,20,100);  
                    Console.WriteLine();
                    break;
                case 9:

                    EmpWages TATA = new EmpWages("TATA", 20, 20, 100);
                    EmpWages BMW = new EmpWages("BMW", 20, 20, 100);
                    EmpWages TCS = new EmpWages("TCS", 20, 20, 100);

                    TATA.ComputeEmployeeWage();
                    Console.WriteLine(TATA.ToString());
                    BMW.ComputeEmployeeWage();
                    Console.WriteLine(BMW.ToString());
                     TCS.ComputeEmployeeWage();
                    Console.WriteLine(TCS.ToString());
                    break ;
                case 10:
                    EmpWageBuilder empWageBuilderArray = new EmpWageBuilder();
                    empWageBuilderArray.addCompanyEmpWage("TATA", 20, 2, 10);
                    empWageBuilderArray.addCompanyEmpWage("BMW", 10, 4, 20);
                    empWageBuilderArray.addCompanyEmpWage("TCS", 10, 4, 20);
                    empWageBuilderArray.computeEmpWage();
                    break ;
                case 11:
                    EmpWageBuilder11 empWageBuilder = new EmpWageBuilder11();
                    empWageBuilder.AddCompanyEmpWage("TATA", 20, 2, 10);
                    empWageBuilder.AddCompanyEmpWage("BMW", 10, 4, 20);
                    empWageBuilder.AddCompanyEmpWage("TCS", 10, 4, 20);
                    empWageBuilder.ComputeEmpWage();
                    break;

            }
        }
    }
}