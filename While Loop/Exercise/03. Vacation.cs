double money_needed = double.Parse(Console.ReadLine());
double money_had = double.Parse(Console.ReadLine());
int counter = 0;
int counter_days = 0;


while (counter < 5 && money_had < money_needed)
{
     string type = Console.ReadLine();
     double amount = double.Parse(Console.ReadLine());

     if (type == "spend")
     {
        money_had -= amount;
        counter += 1;
     }
     else if (type == "save")
     {
        money_had += amount;
        counter = 0;
     }

    counter_days += 1;

    if (money_had < 0)
    {
        money_had = 0;
    }
}

if (money_had >= money_needed)
{
    Console.WriteLine($"You saved the money for {counter_days} days.");
}


if (counter >= 5)
{
    Console.WriteLine($"You can't save the money.");
    Console.WriteLine($"{counter_days}");
}
