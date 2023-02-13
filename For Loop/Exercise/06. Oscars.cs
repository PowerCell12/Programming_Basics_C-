string name = Console.ReadLine();
double points = Double.Parse(Console.ReadLine());
int number = int.Parse(Console.ReadLine());
double points2 = 0;
double points3 = 0;

int counter = 0;

for (int i = 0; i < number; i++)
{
    string name1 = Console.ReadLine();
    double points_everyone = Double.Parse(Console.ReadLine());
    counter += 1;

    if (counter == 1)
    {
        points2 = points + ((name1.Length * points_everyone) / 2);
    }
    else
    {
    points3 = points2 + ((name1.Length * points_everyone) / 2);
    
    points2 = points3;
    }


    if (points3 > 1250.5)
    {
        Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points3:f1}!");
        break;
    }
}

if (points3 < 1250.6)
{
    double final = 1250.5 - points2;
    Console.WriteLine($"Sorry, {name} you need {final:f1} more!");
}
