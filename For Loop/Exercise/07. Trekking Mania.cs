int how_many = int.Parse(Console.ReadLine());
int group1 = 0;
int group2 = 0;
int group3 = 0;
int group4 = 0;
int group5 = 0;
int all_people = 0;

for (int i = 0; i < how_many; i++)
{
    int numbers = int.Parse(Console.ReadLine());

    all_people += numbers;

    if (numbers < 6)
    {
        group1 += numbers;
    }
    else if (5 < numbers && numbers < 13)
    {
        group2 += numbers;
    }
    else if (12 < numbers && numbers < 26)
    {
        group3 += numbers;
    }
    else if (25 < numbers && numbers < 41)
    {
        group4 += numbers;
    }
    else if (numbers > 40)
    {
        group5 += numbers;
    }
}


double final = (group1 * 100.0) / all_people;
double final1 = (group2 * 100.0) / all_people;
double final2 = (group3 * 100.0) / all_people;
double final3 = (group4 * 100.0) / all_people;
double final4 = (group5 * 100.0) / all_people;

Console.WriteLine($"{final:f2}%");
Console.WriteLine($"{final1:f2}%");
Console.WriteLine($"{final2:f2}%");
Console.WriteLine($"{final3:f2}%");
Console.WriteLine($"{final4:f2}%");
