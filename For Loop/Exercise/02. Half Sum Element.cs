int Max = int.MinValue;
int repetitions = int.Parse(Console.ReadLine());
int all1 = 0;
int  all = 0;
for (int i = 0; i < repetitions; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number > Max)
    {
        Max = number;
    }
    all += number;
}

all1 = all - Max;
if (Max == all1)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {Max}");
}
else
{
    int diff = Max - all1;
    if (diff < 0)
    {
        int diff1 = -diff;
         Console.WriteLine($"No");
        Console.WriteLine($"Diff = {diff1}");
    }
    else
    {
        Console.WriteLine($"No");
        Console.WriteLine($"Diff = {diff}");
    }
}
