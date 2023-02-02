double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string where = " ";
double final = 0;
string country = " ";

switch (season)
{
    case "summer":
       where = "Camp";
       break;

    case "winter":
       where = "Hotel";
       break;
}

if (budget <= 100)
{
    if (season == "summer")
    {
        final = budget * 30 / 100;
    }
    else if (season == "winter")
    {
        final = budget * 70 / 100;
    }
    country = "Bulgaria";
}
else if (budget <= 1000)
{
    if (season == "summer")
    {
        final = budget * 40 / 100;
    }
    else if (season == "winter")
    {
        final = budget * 80 / 100;
    }
    country = "Balkans";
}
else if (budget > 1000)
{
    where = "Hotel";
    final = budget * 90 / 100;
    country = "Europe";
}

Console.WriteLine($"Somewhere in {country}");
Console.WriteLine($"{where} - {final:f2}");
