int number = int.Parse(Console.ReadLine());
int counter = 0;

for (int i = 0; i < number + 1; i++)
{
    for (int j = 0; j < number + 1; j++)
    {
        for (int k = 0; k < number + 1; k++)
        {
            int final = i + j + k;
            if (final == number)
            {
                counter += 1;
            }
        }
    }
}


Console.WriteLine(counter);
