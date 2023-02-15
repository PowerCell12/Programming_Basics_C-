int steps = 0;

while (steps < 10000)
{
  string step = Console.ReadLine();

  if (step == "Going home")
  {
     int addtionalsteos = int.Parse(Console.ReadLine());
     steps += addtionalsteos;
     break;
  }

  int step1 = int.Parse(step);
  steps += step1;
}


if (steps >= 10000)
{
  int steps_left = steps - 10000;
  Console.WriteLine("Goal reached! Good job!");
  Console.WriteLine($"{steps_left} steps over the goal!");
 }
 else
 {
  int steps_needed = 10000 - steps;
  Console.WriteLine($"{steps_needed} more steps to reach goal.");
}
