string type = Console.ReadLine();
int lines = int.Parse(Console.ReadLine());
int colons = int.Parse(Console.ReadLine());
double money = 0;

if (type == "Premiere")
{
    money = 12.00;
}
else if (type == "Normal")
{
    money = 7.50;
}
else if (type == "Discount")
{
    money = 5.00;
}

double final_structure = colons * lines;

double final = final_structure * money;


Console.WriteLine($"{final:f2}");
Console.WriteLine("leva");
