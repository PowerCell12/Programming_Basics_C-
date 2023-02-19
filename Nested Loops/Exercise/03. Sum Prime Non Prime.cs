string numbers = "";
bool first = true;
int prime = 0;
int non_prime = 0;

while (numbers != "stop")
{
  numbers = Console.ReadLine();

  if (numbers == "stop")
  {
    break;
  }

  int number = int.Parse(numbers);

  if (number < 0)
  {
    Console.WriteLine("Number is negative.");
    continue;
  }

  for (int i = 2; i < number; i++)
  {
    for (int j = 2; j < number; j++)
    {
      if (i * j == number)
      {
        first = false;
        break;
      }
    }
    if (first == false)
    {
      break;
    }
  }

  if (first)
  {
    prime += number;
  }
  else
  {
    non_prime += number;
  }

  first = true;
  }


Console.WriteLine($"Sum of all prime numbers is: {prime}");
Console.WriteLine($"Sum of all non prime numbers is: {non_prime}");
