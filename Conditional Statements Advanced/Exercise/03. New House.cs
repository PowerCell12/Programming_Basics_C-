string type = Console.ReadLine();
int howmany = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double cost = 0;
int percentage = 0;

switch (type)
{
    case "Roses":
        cost = 5;
        if (howmany > 80)
        {
            percentage = 10;
        }
        break;

    case "Dahlias":
        cost = 3.80;
        if (howmany > 90)
        {
            percentage = 15;
        }
            break;
    
    case "Tulips":
        cost = 2.80;
        if (howmany > 80)
        {
            percentage = 15;
        }
        break;

    case "Narcissus":
        cost = 3;
        if (howmany < 120)
        {
            percentage = 15;
        }
        break;
    
    case "Gladiolus":
        cost = 2.50;
        if (howmany < 80 )
        {
            percentage = 20;
        }
        break;
}


double final = howmany * cost;
double final1 = 0;

if (type == "Narcissus" || type == "Gladiolus")
{
    final = final + (final * percentage / 100);
}
else
{
    final = final - (final * percentage / 100);
}

if (budget >= final)
{
    final1 = budget - final;
    Console.WriteLine($"Hey, you have a great garden with {howmany} {type} and {final1:f2} leva left.");
}
else
{
    final1 = final - budget;
    Console.WriteLine($"Not enough money, you need {final1:f2} leva more.");
}
