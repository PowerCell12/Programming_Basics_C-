string money = Console.ReadLine();
double allmoney = 0;

while (money != "NoMoreMoney")
{
    double money1 = double.Parse(money);
    if (money1 < 0)
    {
        Console.WriteLine($"Invalid operation!");
        break;
    }
    else;
    {
        allmoney += money1;
    }
    Console.WriteLine($"Increase: {money1:f2}");
    money = Console.ReadLine();
}

Console.WriteLine($"Total: {allmoney:f2}");
