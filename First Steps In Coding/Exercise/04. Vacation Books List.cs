int number_of_pages = int.Parse(Console.ReadLine());

int pages_for_1_hours = int.Parse(Console.ReadLine());

int days = int.Parse(Console.ReadLine());

int hours_needed = number_of_pages / pages_for_1_hours;

int hours_for_a_day = hours_needed / days;

Console.WriteLine(hours_for_a_day);
