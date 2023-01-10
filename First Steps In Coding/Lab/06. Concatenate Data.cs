using System;

namespace HelloSoftuni
{

    class program
    {
        static void Main(string[] args)
        {
         string First_name = Console.ReadLine();
         string last_name  = Console.ReadLine(); 
         int age = int.Parse(Console.ReadLine());
         string town = Console.ReadLine();
         Console.WriteLine($"You are {First_name} {last_name}, a {age}-years old person from {town}.");
        }
    }
}
