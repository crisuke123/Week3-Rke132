
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);//o-6

switch (weekDay)//väärtus mida kondrolitakse 
{
    case 0:   //case 0: == if (weekday == 0)
        Console.WriteLine("It`s Sunday!");
        break;
        case 1:
        Console.WriteLine("It`s Monday!");
        break ;
        case 2:
        Console.WriteLine("It`s Tuesday!");
        break;
    case 3:
        Console.WriteLine("It`s wendsday!");
        break;
        case 4:
        Console.WriteLine("It`s Thursday!");
        break;
    case 5:
        Console.WriteLine("It`s friday!");
        break;
    case 6:
        Console.WriteLine("It`s Saturday!");
        break;

        default:
        Console.WriteLine("Oops.Your calender must be broken");
        break;
}

Console.WriteLine("Have a nice day!");