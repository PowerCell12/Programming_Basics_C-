int number = int.Parse(Console.ReadLine());
int Max = int.MinValue;
int Min = int.MaxValue;

for (int i = 0; i < number; i++)
{
    int numbers =  int.Parse(Console.ReadLine());
    if (numbers > Max)
    {
        Max = numbers;
    }

    if (numbers < Min)
    {
        Min = numbers;
    }
}

Console.WriteLine($"Max number: {Max}");
Console.WriteLine($"Min number: {Min}");
