int number = int.Parse(Console.ReadLine());

for (int i = 0; i <= number; i ++)
{
    if (i % 2 == 0)
    {
        if (i == 0)
        {
            Console.WriteLine(1);
            continue;
        }
        else
        {
        Console.WriteLine(Math.Pow(2, i));
        }
    }
}
