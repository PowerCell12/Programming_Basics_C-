string typefood = Console.ReadLine();
string city =  Console.ReadLine();
double howmany = double.Parse(Console.ReadLine());

double coffee = 0;
double water = 0;
double beer = 0;
double sweets = 0;
double peanuts = 0;

double final = 0;



if (city == "Sofia")
{
    if (typefood == "coffee")
    {
        final = 0.50;
    }
    else if (typefood == "water")
    {
        final = 0.80;
    }
    else if (typefood == "beer")
    {
        final = 1.20;
    }
    else if (typefood == "sweets")
    {
        final = 1.45;
    }
    else if (typefood == "peanuts")
    {
        final = 1.60;
    }
}
else if (city == "Plovdiv")
{
    if (typefood == "coffee")
    {
        final = 0.40;
    }
    else if (typefood == "water")
    {
        final = 0.70;
    }
    else if (typefood == "beer")
    {
        final = 1.15;
    }
    else if (typefood == "sweets")
    {
        final = 1.30;
    }
    else if (typefood == "peanuts")
    {
        final = 1.50;
    }
}
else if (city == "Varna")
{
    if (typefood == "coffee")
    {
        final = 0.45;
    }
    else if (typefood == "water")
    {
        final = 0.70;
    }
    else if (typefood == "beer")
    {
        final = 1.10;
    }
    else if (typefood == "sweets")
    {
        final = 1.35;
    }
    else if (typefood == "peanuts")
    {
        final = 1.55;
    }
}

final = final * howmany;

Console.WriteLine(final);
