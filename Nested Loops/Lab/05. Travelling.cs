string place = "";
double all = 0;

while (place != "End")
{
    place = Console.ReadLine();

    if (place == "End")
    {
        break;
    }
    double money_needed = double.Parse(Console.ReadLine());
    
    while (all < money_needed) 
    {
        double money = double.Parse(Console.ReadLine());

        all += money;
    }

    all = 0;
    Console.WriteLine($"Going to {place}!");
}
