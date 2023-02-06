int number = int.Parse(Console.ReadLine());
int diff1  = 0;
int diff2 = 0;

for (int i = 0; i < number; i++)
{
    int numbers = int.Parse(Console.ReadLine());
    diff1 += numbers;
}

for (int i = 0; i < number; i++)
{
    int numbers1 = int.Parse(Console.ReadLine());
    diff2 += numbers1;
}

if (diff1 == diff2)
{
    Console.WriteLine($" Yes, sum = {diff1}");
}
else
{
    int diff_final = (diff1 - diff2);
    int diff_final1 = 0;
    if (diff_final < 0)
    {
        diff_final1 = -diff_final;
        Console.WriteLine($" No, diff = {diff_final1}");
    }
    else
    {
        Console.WriteLine($" No, diff = {diff_final}");
    }
}
