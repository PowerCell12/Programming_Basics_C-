int counter = 2;
int numbers = int.Parse(Console.ReadLine());
int counter1 = 0;

while (counter1 != numbers)
{
    for (int i = 1; i  < counter; i++)
    {
        counter1++;
        Console.Write(counter1);
        Console.Write(" ");
        if  (counter1 == numbers)
        {
            break;
        }
    }
    counter++;
    Console.WriteLine();
}
