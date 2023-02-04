double days = double.Parse(Console.ReadLine());
string type = Console.ReadLine();
string grade = Console.ReadLine();
int percengate = 0;
double money = 0;
double days1 = days - 1;

switch (type)
{
    case "room for one person":
    {
        money = 18;
        break;
    }

    case "apartment":
    {
        if (days < 10)
        {
            percengate = 30;
        }
        else if (9 < days && days < 16)
        {
            percengate = 35;
        }
        else if (days >15)
        {
            percengate = 50;
        }
        money = 25;
        break;
    }
    
    case "president apartment":
    {
        if (days < 10)
        {
            percengate = 10;
        }
        else if (9 < days && days < 16)
        {
            percengate = 15;
        }
        else if (days >15)
        {
            percengate = 20;
        }
        money = 35;
        break;
    }   
}
double final2 = 0;
double final = money * days1;

double final1 = final - (final * percengate / 100);

if (grade == "positive")
{
    final2 = final1 + (final1 * 25 / 100);
}
else if (grade == "negative")
{
     final2 = final1 - (final1 * 10 / 100);
}

Console.WriteLine($"{final2:f2}");
