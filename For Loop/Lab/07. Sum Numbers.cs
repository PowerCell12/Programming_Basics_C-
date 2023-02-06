int lines = int.Parse(Console.ReadLine());
int all_numbers = 0;

for (int i = 1; i <= lines; i++)
{  
    int number = int.Parse(Console.ReadLine());
    all_numbers += number;
}

Console.WriteLine(all_numbers);
