double sum = double.Parse(Console.ReadLine());

double time_for_it = double.Parse(Console.ReadLine());

double yearly_percentage = double.Parse(Console.ReadLine());

double final1 = sum * yearly_percentage / 100;

double final2 = final1 / 12;

double final3 = sum + time_for_it * final2;

Console.WriteLine(final3);
