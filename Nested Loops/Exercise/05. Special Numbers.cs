int divisor = int.Parse(Console.ReadLine());
int counter = 0;
bool flag = true;

for (int i = 1111; i <= 9999; i++)
{
  for (int j = 0; j < i.ToString().Length; j++)
  {
    string s = i.ToString();
    char c = s[counter];
    int result = c - '0';
  
    counter += 1;

    if (result == 0)
    {
      flag = false;
      break;
    }

    if (divisor % result == 0)
    {
      continue;
    }
    else
    {
      flag = false;
    }
      
   if (flag == false)
   {
    break;
   }

  }

  if (flag)
  {
    Console.Write(i);
    Console.Write(" ");
  }

  flag = true;
  counter = 0;
}
