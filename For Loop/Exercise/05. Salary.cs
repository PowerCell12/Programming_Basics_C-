int tabs_open = int.Parse(Console.ReadLine());
int pay = int.Parse(Console.ReadLine());
int money_toremove = 0;
int money_left = 0;

for (int i = 0; i < tabs_open; i++)
{
    string tabs = Console.ReadLine();
    if (tabs == "Facebook")
    {
        money_toremove += 150;
    }
    else if (tabs == "Instagram")
    {
        money_toremove += 100;
    }
    else if (tabs == "Reddit")
    {
        money_toremove += 50;
    }
    money_left = pay - money_toremove;
    if (money_left <= 0)
    {
        Console.WriteLine($"You have lost your salary.");
        break;   
    }
}

if (money_left > 0)
{
    Console.WriteLine($"{money_left:f0}");
}
