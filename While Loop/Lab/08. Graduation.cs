string name = Console.ReadLine();
double average = 0;
double counter = 0;
double counter_grade = 0;
bool bootlang = true;
double counter_grade1 = 0;


while (bootlang)
{
    if (counter > 1)
    {
        break;
    }

    double grade = Double.Parse(Console.ReadLine());
    counter_grade += 1;
    average += grade;

    if (counter_grade == 12)
    {
        break;
    }
    
    if (grade < 4)
    {
        counter += 1;
    }

}

if (counter > 1)
    {
        counter_grade1 = counter_grade - 1;
        Console.WriteLine($"{name} has been excluded at {counter_grade1} grade");
    }
else
{
    double average_final = average / counter_grade;
    Console.WriteLine($"{name} graduated. Average grade: {average_final:f2}");
}
