int hours_exam = int.Parse(Console.ReadLine());
int minutes_exam = int.Parse(Console.ReadLine());
int hours_there = int.Parse(Console.ReadLine());
int minutes_there = int.Parse(Console.ReadLine());
int final1  = 0;
int hours  = 0;
int minutes = 0;


int minutes_exam_final = hours_exam *  60 + minutes_exam;
int minutes_there_final = hours_there *  60 + minutes_there;

if (minutes_there_final > minutes_exam_final)
{
    Console.WriteLine("Late");
    final1 = minutes_there_final - minutes_exam_final;
    if (final1 >= 60)
    {
        hours = final1 / 60;
        minutes = final1 % 60;
        Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
    }
    else
    {
    Console.WriteLine($"{final1} minutes after the start");
    }
}
else if (minutes_there_final < minutes_exam_final - 30)
{
    Console.WriteLine("Early");
    final1 = minutes_exam_final - minutes_there_final;
    if (final1 >= 60)
    {
        hours = final1 / 60;
        minutes = final1 % 60;
        Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
    }
    else
    {
    Console.WriteLine($"{final1} minutes before the start");
    }
}
else
{
    Console.WriteLine("On time");
    final1 = minutes_exam_final - minutes_there_final;
    Console.WriteLine($"{final1} minutes before the start");
}
