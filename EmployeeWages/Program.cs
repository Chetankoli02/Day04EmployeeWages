using EmployeeWages;

internal class Program
{
    private static void Main(string[] args)
    {
        CheckEmployee checkEmployee = new CheckEmployee();
        checkEmployee.Main(args);

        DailyWages dailyWages = new DailyWages();
        dailyWages.Main(args);

        PartTimeWages partTimeWages = new PartTimeWages();
        partTimeWages.Main(args);
    }
}