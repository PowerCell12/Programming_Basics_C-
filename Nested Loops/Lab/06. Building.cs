int floors = int.Parse(Console.ReadLine());
int rooms_per = int.Parse(Console.ReadLine());
int floors1 = floors;
int counter = floors;
string letter = "";
int number_office = 0;

for (int i = floors; i > 0; i--)
{
    if (floors == 1)
    {
        floors = rooms_per;
    }
    for (int j = rooms_per; j > 0; j--)
    {
        if (floors1 == 1)
        {
            letter = "L";

            if (number_office == 0)
            {
            Console.Write($"{letter}{counter}{number_office}");
            }
            else
            {
                Console.Write(" ");
                Console.Write($"{letter}{counter}{number_office}");
            }

            number_office += 1;

            continue;
        }
        if (counter == floors)
        {
            if (number_office == 0)
            {
            Console.Write($"L{counter}{number_office}");
            }
            else
            {
                Console.Write(" ");
                Console.Write($"L{counter}{number_office}");
            }

            number_office += 1;

            continue;
        }
        if (counter % 2 ==0)
        {
            letter = "O";

            if (number_office == 0)
            {
            Console.Write($"{letter}{counter}{number_office}");
            }
            else
            {
                Console.Write(" ");
                Console.Write($"{letter}{counter}{number_office}");
            }

            number_office += 1;
        }
        else
        {
            letter = "A";

            
            if (number_office == 0)
            {
            Console.Write($"{letter}{counter}{number_office}");
            }
            else
            {
                Console.Write(" ");
                Console.Write($"{letter}{counter}{number_office}");
            }

            number_office += 1;
        }    
    }
    number_office = 0;

    counter -= 1;
    Console.Write("\n");
}
