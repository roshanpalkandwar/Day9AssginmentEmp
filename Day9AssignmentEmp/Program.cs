namespace Day9AssignmentEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welecome to employee wages");
            Console.WriteLine("chooes number\n1.EMp present absent\n2.Daily wages\n3.Part time wages\n4.using switch loop\n5. wages FOr Month\n6.using while loop\n7.Monthly emp wages");
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
            }
        }
    }
}