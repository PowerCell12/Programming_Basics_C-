int number = int.Parse(Console.ReadLine());


if ((-101 < number) && (number <= 100))
{
    if (number != 0)
    Console.WriteLine("Yes");
    else
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("No");
}
