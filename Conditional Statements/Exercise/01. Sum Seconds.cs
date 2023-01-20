int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

int all = first + second + third;
int minutes = all / 60;
double seconds = all % 60;

if(seconds < 10)
{
  Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
  Console.WriteLine($"{minutes}:{seconds}");
}
