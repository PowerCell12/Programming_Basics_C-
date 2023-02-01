string plod = Console.ReadLine();
string day = Console.ReadLine();
double how_many = double.Parse(Console.ReadLine());
double final = 0;

switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (plod)
        {
            case "banana":
                final = 2.50;
                break;
            case "apple":
                final = 1.20;
                break;
            case "orange":
                final = 0.85;
                break;
            case "grapefruit":
                final = 1.45;
                break;
            case "kiwi":
                final = 2.70;
                break;
            case "pineapple":
                final = 5.50;
                break;
            case "grapes":
                final = 3.85;
                break;
        }
        break;


    case "Saturday":
    case "Sunday":
        switch (plod)
        {
            case "banana":
                final = 2.70;
                break;
            case "apple":
                final = 1.25;
                break;
            case "orange":
                final = 0.90;
                break;
            case "grapefruit":
                final = 1.60;
                break;
            case "kiwi":
                final = 3.00;
                break;
            case "pineapple":
                final = 5.60;
                break;
            case "grapes":
                final = 4.20;
                break;
        }
        break;
}

double FinalPrice = final * how_many;
if (FinalPrice > 0)
{
Console.WriteLine($"{FinalPrice:f2}");
}
else
{
    Console.WriteLine("error");
}
