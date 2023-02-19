int counter = 0;
int counter1 = 0;
int standard = 0;
int student = 0; 
int kids = 0;


while (true)
{
  string name  = Console.ReadLine();
  
  if (name == "Finish")
  {
    double final_student = (student * 100.00)  / counter1;
    double final_kids = (kids * 100.00)  / counter1;
    double final_standard = (standard * 100.00) / counter1;

    Console.WriteLine($"Total tickets: {counter1}");
    Console.WriteLine($"{final_student:F2}% student tickets.");
    Console.WriteLine($"{final_standard:F2}% standard tickets.");
    Console.WriteLine($"{final_kids:F2}% kids tickets.");
    break;
  }

  
  int space = int.Parse(Console.ReadLine());
    
  for (int i = 0; i < space; i++)
    {
      string type = Console.ReadLine();

      if (type == "End")
      {
        break;
      }

      counter++;
      counter1++;

      if (type == "standard")
      {
        standard += 1;
      }

      if (type == "student")
      {
        student += 1;
      }

      if (type == "kid")
      {
        kids += 1;
      }

    }


  double final = (counter * 100.00) / space;

  Console.WriteLine($"{name} - {final:F2}% full.");

  counter = 0;  
}
