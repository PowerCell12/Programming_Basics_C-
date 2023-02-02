int budget = int.Parse(Console.ReadLine());
string seson  = Console.ReadLine();
int number = int.Parse(Console.ReadLine());
int priceseson = 0;
int percentage = 0;
int priceoff = 0;

switch (seson)
{
    case "Spring":
      priceseson = 3000;
      break;

    case "Summer":
    case "Autumn":
      priceseson = 4200;
      break;

    case "Winter":
      priceseson = 2600;
      break;
}


if (number <= 6)
{
    percentage = 10;
}
else if (6 < number && number <= 11)
{
    percentage = 15;
}
else if (number >= 12)
{
    percentage = 25;
}


if (number % 2 == 0 && seson != "Autumn")
{
    priceoff = 5;
}

double final  = priceseson - (priceseson * percentage / 100);
double final1 = final - (final * priceoff / 100);

if (budget >= final1)
{
    double final2 = budget - final1;
    Console.WriteLine($"Yes! You have {final2:f2} leva left.");
}
else
{
    double final2 = final1 - budget;
    Console.WriteLine($"Not enough money! You need {final2:f2} leva.");
}
