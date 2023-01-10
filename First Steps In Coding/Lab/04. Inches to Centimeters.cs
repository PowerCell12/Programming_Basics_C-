using System;

namespace HelloSoftuni
{

    class program
    {
        static void Main(string[] args)
        {
           double number = double.Parse(Console.ReadLine());
           double inches = 2.54;
           double centimeters = number * inches;
           Console.WriteLine(centimeters);
        }
    }
}
