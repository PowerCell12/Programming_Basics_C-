string city = Console.ReadLine();
double paytout = Double.Parse(Console.ReadLine());
double percent = 0;


switch (city)
{
    case "Sofia":
        if ((0 <= paytout) && (paytout <= 500))
        {
            percent = 5;
        }
        else if ((500 < paytout) && (paytout <= 1000))
        {
            percent = 7;
        }
        else if ((1000 < paytout) && (paytout <= 10000))
        {
            percent = 8;
        }
        else if ((paytout > 10000))
        {
            percent = 12;
        }
        break;

        case "Varna":
        if ((0 <= paytout) && (paytout <= 500))
        {
            percent = 4.5;
        }
        else if ((500 < paytout) && (paytout <= 1000))
        {
            percent = 7.5;
        }
        else if ((1000 < paytout) && (paytout <= 10000))
        {
            percent = 10;
        }
        else if ((paytout > 10000))
        {
            percent = 13;
        }
        break;


        case "Plovdiv":
        if ((0 <= paytout) && (paytout <= 500))
        {
            percent = 5.5;
        }
        else if ((500 < paytout) && (paytout <= 1000))
        {
            percent = 8;
        }
        else if ((1000 < paytout) && (paytout <= 10000))
        {
            percent = 12;
        }
        else if ((paytout > 10000))
        {
            percent = 14.5;
        }
        break;
}



double percent1 = percent / 100;

double final = paytout * percent1;


if (final == 0)
{
    Console.WriteLine("error");
}
else
{
    Console.WriteLine($"{final:f2}");
}
