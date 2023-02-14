string number = Console.ReadLine();
double Max = int.MinValue;
double number1 = 0;


while (number != "Stop")
{
    number1 = double.Parse(number);
    if (number1 > Max)
    {
        Max = number1;
    }
    number  = Console.ReadLine();
}

Console.WriteLine(Max);
