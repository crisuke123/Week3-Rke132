
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
Console.WriteLine(weekDay);
Console.WriteLine(DateTime.Now);

if (weekDay == 0)
{
    Console.WriteLine("It´s Sunday!");
}
else if (weekDay == 1)
{
    Console.WriteLine("It´s Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("It´s Tuesday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("It´s wendsday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("It´s Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("It´s friday!");
}
else if (weekDay == 6)
{
    Console.WriteLine("It´s Saturday!");
}

Console.WriteLine("Have a nice day");