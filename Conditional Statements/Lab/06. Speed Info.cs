double speed = double.Parse(Console.ReadLine());

if(speed < 10.01)
{
  Console.WriteLine("slow");
}
if(speed > 10 && speed < 50.01)
{
  Console.WriteLine("average");
}
if(speed > 50 && speed < 150.01)
{
  Console.WriteLine("fast");
}
if(speed > 150 && speed < 1000.01)
{
  Console.WriteLine("ultra fast");
}
if(speed > 1000)
{
  Console.WriteLine("extremely fast");
}
