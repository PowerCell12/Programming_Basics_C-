double chicken = double.Parse(Console.ReadLine()) * 10.35;

double fish = double.Parse(Console.ReadLine()) * 12.40;
    
double vegetarian = double.Parse(Console.ReadLine()) * 8.15;
    
double all = chicken + fish + vegetarian;
    
double desert = all  * 0.2;
    
double final = all + desert + 2.50;
    
Console.WriteLine(final);
