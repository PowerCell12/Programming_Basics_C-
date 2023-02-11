int interetations = int.Parse(Console.ReadLine());
int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;
int n = 0;

for (int i = 0; i < interetations; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        p1 += 1;
    }
    else if (199 < number && number < 400)
    {
        p2 += 1;
    }
    else if (399 < number && number < 600)
    {
        p3 += 1;
    }
    else if (599 < number && number < 800)
    {
        p4 += 1;
    }
    else if (number > 799)
    {
        p5 += 1;
    }
    n += 1;
}


double p1_final =  (p1 * 100.0) / n;
double p2_final = (p2 * 100.0) / n;
double p3_final = (p3 * 100.0) / n;
double p4_final = (p4 * 100.0) / n;
double p5_final = (p5 * 100.0) / n;

Console.WriteLine($"{p1_final:f2}%");
Console.WriteLine($"{p2_final:f2}%");
Console.WriteLine($"{p3_final:f2}%");
Console.WriteLine($"{p4_final:f2}%");
Console.WriteLine($"{p5_final:f2}%");
