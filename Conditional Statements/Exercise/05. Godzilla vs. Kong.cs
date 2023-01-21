double budget = double.Parse(Console.ReadLine());
int number = int.Parse(Console.ReadLine());
double money = double.Parse(Console.ReadLine());

double dakor = budget * 0.1;

double clothes = number * money;

if (number > 150)
{
    clothes = clothes - clothes * 0.1;
}

double finalsum = clothes + dakor;

double moneyleft = budget - finalsum;
double moneyneeded = finalsum - budget;

if ((budget - finalsum) >= 0)
{
 Console.WriteLine("Action!");
 Console.WriteLine($"Wingard starts filming with {moneyleft:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {moneyneeded:f2} leva more.");
}
