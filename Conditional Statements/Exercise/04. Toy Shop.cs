double moneytravel = double.Parse(Console.ReadLine());
double puzzle = double.Parse(Console.ReadLine());
int doll = int.Parse(Console.ReadLine());
double bear = double.Parse(Console.ReadLine());
double minion = double.Parse(Console.ReadLine());
int truck = int.Parse(Console.ReadLine());

double toys = puzzle + doll + bear + minion + truck;
double money = puzzle * 2.60 + doll * 3 + bear * 4.10 + minion * 8.20 + truck * 2;

if (toys >= 50)
{
money = money * 0.75;
}

double moneyfinal = money * 0.90;

double moneyleft = moneyfinal - moneytravel;
double moneyneeded = moneytravel - moneyfinal;

if ((moneyfinal - moneytravel) >= 0)
{
Console.WriteLine($"Yes! {moneyleft:f2} lv left.");
}
else
{
Console.WriteLine($"Not enough money! {moneyneeded:f2} lv needed.");
}
