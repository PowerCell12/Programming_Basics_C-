float yearsold = float.Parse(Console.ReadLine());
string pol = Console.ReadLine();

if (pol == "m")
{
    if (yearsold >= 16)
    {
        Console.WriteLine("Mr.");
    }
    else
    {
        Console.WriteLine("Master");
    }
}

if (pol == "f")
{
    if (yearsold >= 16)
    {
        Console.WriteLine("Ms.");
    }
    else
    {
        Console.WriteLine("Miss");
    }
}
