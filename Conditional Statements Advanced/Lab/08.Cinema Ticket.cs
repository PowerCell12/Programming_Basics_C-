string day = Console.ReadLine();
int money = 0;

switch (day)
{
    case "Monday":
        money = 12;
        break;
    case "Tuesday":
        money = 12;
        break;
    case "Wednesday":
        money = 14;
        break;
    case "Thursday":
        money = 14;
        break;
    case "Friday":
        money = 12;
        break;
    case "Saturday":
      money = 16;
        break;
    case "Sunday":
        money = 16;
        break;
    default:
    break;
}


Console.WriteLine(money);
