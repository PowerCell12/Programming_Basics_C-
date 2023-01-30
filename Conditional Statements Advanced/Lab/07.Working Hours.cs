int number = int.Parse(Console.ReadLine());
string text = Console.ReadLine();

if ((number > 9) && (number < 19)  && (text != "Sunday"))
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}
