string number = Console.ReadLine();
double Min = int.MaxValue;
double number1 = 0;

while (number != "Stop")
{
    number1 = double.Parse(number);
    if (number1 < Min)
    {
        Min = number1;
    }
    number = Console.ReadLine();
}

Console.WriteLine(Min);
