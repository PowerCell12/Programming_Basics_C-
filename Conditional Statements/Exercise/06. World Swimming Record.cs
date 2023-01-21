double recordseconds = double.Parse(Console.ReadLine());
float meters = float.Parse(Console.ReadLine());
double time = double.Parse(Console.ReadLine());

double timeIvan = time * meters;

int meters1 = (int)meters;
int timewater = meters1 / 15;
double timewater1 = (double)timewater;
double timewater2  = timewater1 * 12.5;

double alltime = timewater2  + timeIvan;
double timeup = alltime - recordseconds;


if (alltime < recordseconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {alltime:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {timeup:f2} seconds slower.");
}
