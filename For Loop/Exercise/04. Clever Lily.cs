int years = int.Parse(Console.ReadLine());
double price = double.Parse(Console.ReadLine());
int price_toy = int.Parse(Console.ReadLine());
int money_counter = 0;
int counter_toys = 0;
int money_counter_1 = 0;
int brother_counter = 0;
int money_counter_final = 0;

for (int i = 1; i <= years; i++)
{
    if (i % 2 == 0)
    {
        brother_counter += 1;
        money_counter = 10;
        money_counter_1 += 1;
        money_counter_final += money_counter * money_counter_1;
    }
    else
    {
        counter_toys += 1;
    }
}


int counter_toys_final = counter_toys * price_toy;
int brother =  brother_counter * 1;
double final = (money_counter_final + counter_toys_final) - brother;

if (final >= price)
{
    double fianl1 = final - price;
    Console.WriteLine($"Yes! {fianl1:f2}");
}
else
{
    double final2 = price - final;
    Console.WriteLine($"No! {final2:f2}");
}
