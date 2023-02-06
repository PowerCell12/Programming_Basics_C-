int lenght = int.Parse(Console.ReadLine());
int sum1 = 0;
int sum2 = 0;

for (int i = 0; i < lenght; i++)
{
    int numbers = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        sum1 += numbers;
    }
    else
    {
        sum2 += numbers;
    }
}

if (sum1 == sum2)
{
    Console.WriteLine($"Yes");
    Console.WriteLine($"Sum = {sum1}");
}
else
{
    int sum_final = 0;
    sum_final = sum1 - sum2;
    if (sum_final < 0)
    {
        sum_final = -sum_final;
    }
    Console.WriteLine($"No");
    Console.WriteLine($"Diff = {sum_final}");
}
