double budget = double.Parse(Console.ReadLine());
int videocards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

int allofthem = videocards + processors + ram;
double videocardsmoney = videocards * 250;
double processorsmoney = (videocardsmoney * 0.35) * processors;
double ramamount = (videocardsmoney * 0.1 * ram);

double moneytotal = videocardsmoney + processorsmoney + ramamount;


if (videocards > processors)
{
    moneytotal = moneytotal * 0.85;
}


double moneyleft = budget - moneytotal;
double moneyneeded  = moneytotal - budget;

if (budget >= moneytotal)
{
    Console.WriteLine($"You have {moneyleft:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {moneyneeded:f2} leva more!");
}
