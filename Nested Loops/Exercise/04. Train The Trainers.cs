int jury = int.Parse(Console.ReadLine());
double all = 0;
int counter = 0;
double all1 = 0;

while (true)
{
  string name = Console.ReadLine();

  if (name == "Finish")
  {
    double grade_final = all1 / counter;
    Console.WriteLine($"Student's final assessment is {grade_final:F2}.");
    break;
  }

  for (int i = 1; i <= jury; i++)
  {
    double grade = double.Parse(Console.ReadLine());

    all += grade;
    all1 += grade;
    counter += 1;
  }

  double FinalGrade = all / jury;

  Console.WriteLine($"{name} - {FinalGrade:F2}.");

  all = 0;
}
