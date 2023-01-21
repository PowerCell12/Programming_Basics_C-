int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes = minutes + 15;

if (minutes >= 60)
{
    hours = hours + 1;
    minutes = minutes - 60;
}

if (hours > 23)
{
    hours =  0;
}
if (minutes >= 10)
{
    Console.WriteLine($"{hours}:{minutes}");
}
else
{
    Console.WriteLine($"{hours}:0{minutes}");
}
