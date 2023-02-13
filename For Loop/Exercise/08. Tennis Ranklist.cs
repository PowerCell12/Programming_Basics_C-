int howmany = int.Parse(Console.ReadLine());
int starting = int.Parse(Console.ReadLine());
int counter = 0;
int starting1 = starting;

for (int i = 0; i < howmany; i++)
{
    string whereto = Console.ReadLine();

    if (whereto == "W")
    {
        starting += 2000;
        counter += 1;
    }
    else if (whereto == "F")
    {
        starting += 1200;
    }
    else if (whereto == "SF")
    {
        starting += 720;
    }
}


int average_points = (starting - starting1) / howmany;
double percentage = (counter * 100.0)  / howmany;

Console.WriteLine($"Final points: {starting}");
Console.WriteLine($"Average points: {average_points}");
Console.WriteLine($"{percentage:f2}%");
