int badgrades = int.Parse(Console.ReadLine());
string text = Console.ReadLine();
int grade = int.Parse(Console.ReadLine());
int counter = 0;
int allgrades = 0;
string last_problem = " ";
int counter1 = 0;

while (text != "Enough")
{
    if (grade <= 4)
    {
        counter += 1;
    }

    if (counter >= badgrades)
    {
        break;
    }


    allgrades += grade;

    if (text != "Enough")
    {
        last_problem = text;
    }

    counter1 += 1;

    text = Console.ReadLine();
    if (text != "Enough")
    {
        grade = int.Parse(Console.ReadLine());
    }
}


if (text == "Enough")
{
    double final  = 0;
    final = (allgrades * 1.00) / counter1;
    Console.WriteLine($"Average score: {final:f2}");
    Console.WriteLine($"Number of problems: {counter1}");
    Console.WriteLine($"Last problem: {last_problem}");
}
else
{
    Console.WriteLine($"You need a break, {counter} poor grades.");
}
