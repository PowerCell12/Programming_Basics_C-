int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int even = 0;
int not_even = 0;
      
while (number1 != number2 + 1)
{
  for (int i = 0; i < number1.ToString().Length; i++)
  {
    if (i % 2 == 0)
      {
        string final = number1.ToString();
        char c = final[i];
        int final1=  c - '0';
        even += final1;
      }
      else
      {
        string final2 = number1.ToString();
        char c1 = final2[i];
        int final3 =  c1 - '0';
        not_even += final3;
      }
  }
      if (even == not_even)
      {
        Console.Write(number1);
        Console.Write(" ");
      }
      even = 0;
      not_even = 0;
      number1++;
}
