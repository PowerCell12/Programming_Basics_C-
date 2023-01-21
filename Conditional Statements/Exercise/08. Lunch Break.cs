string name = Console.ReadLine();
int howlong = int.Parse(Console.ReadLine());
int howlong_is_thebreak  = int.Parse(Console.ReadLine());

double timelunch = howlong_is_thebreak / 8.00;
double timebreak = howlong_is_thebreak / 4.00;
double final = (howlong_is_thebreak - timebreak - timelunch);
double final1 = final - howlong;
double final3 = Math.Ceiling(final1);
double final2 = howlong - final;
double final4 = Math.Ceiling(final2);


if (final >= howlong)
{
    Console.WriteLine($"You have enough time to watch {name} and left with {final3} minutes free time.");
}
else 
{
    Console.WriteLine($"You don't have enough time to watch {name}, you need {final4} more minutes.");
}
