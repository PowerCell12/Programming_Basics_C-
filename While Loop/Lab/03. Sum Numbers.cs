int number = int.Parse(Console.ReadLine());
int add = int.Parse(Console.ReadLine());

while (add < number)
{
    add += int.Parse(Console.ReadLine());
}

Console.WriteLine(add);
