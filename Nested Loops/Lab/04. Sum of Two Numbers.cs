int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int magic = int.Parse(Console.ReadLine());
int counter = 0;
bool success = false;

for (int i = number1; i <= number2; i++)
{
    for (int j = number1; j <= number2; j++)
    {
        counter += 1;
        int final = i + j;
        if (final == magic)
        {
            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magic})");
            success = true;
            break;
        }
    }
    if (success)
    {
        break;
    }

}

if (success == false)
{
    Console.WriteLine($"{counter} combinations - neither equals {magic}");
}
