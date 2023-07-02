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


        SwitchCase switchCase = new SwitchCase();
        switchCase.Main(args);


        MonthWages monthWages = new MonthWages();
        monthWages.Main(args);


        HoursReachedMonth hoursReachedMonth = new HoursReachedMonth();
        hoursReachedMonth.Main(args);
    }
}