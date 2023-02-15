double money = double.Parse(Console.ReadLine());
double only_cens = money * 100;
int counter = 0;


while (only_cens > 0)
{
  if (only_cens >= 200)
  {
    counter += 1;
    only_cens = only_cens - 200;
    if (only_cens >= 200)
    {
      continue;
    }
  }
  if (only_cens >= 100)
  {
    counter += 1;
    only_cens = only_cens - 100;
    if (only_cens >= 100)
    {
      continue;
    }
  }
  if (only_cens >= 50)
  {
    counter += 1;
    only_cens = only_cens - 50;
    if (only_cens >= 50)
    {
      continue;
    }
  }
  if (only_cens >= 20)
  {
    counter += 1;
    only_cens = only_cens - 20;
    if (only_cens >= 20)
    {
        continue;
    }
  }
  if (only_cens >= 10)
  {
    counter += 1;
    only_cens = only_cens - 10;
    if (only_cens >= 10)
    {
      continue;
    }
  }
  if (only_cens >= 5)
  {
    counter += 1;
    only_cens = only_cens - 5;
    if (only_cens >= 5)
    {
      continue;
    }
  }
  if (only_cens >= 2)
  {
    counter += 1;
    only_cens = only_cens - 2;
    if (only_cens >= 2)
    {
      continue;
    }
  }
  if (only_cens >= 1)
  {
    counter += 1;
    only_cens = only_cens - 1;
    if (only_cens >= 1)
    {
      continue;
    }
  }
  else
  {
    break;
  }
}

Console.WriteLine(counter);
