double number = double.Parse(Console.ReadLine());

if(number < 100)
{
  Console.WriteLine("Less than 100");
}

if(number > 99 && number < 201)
{
  Console.WriteLine("Between 100 and 200");
}
if(number > 200)
{
  Console.WriteLine("Greater than 200");
}
