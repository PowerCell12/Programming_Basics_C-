double shield = double.Parse(Console.ReadLine()) * 1.50;
 
double paint = double.Parse(Console.ReadLine()) * 14.50;
    
double distributor_for_paint = double.Parse(Console.ReadLine()) * 5.00;
    
double hours = double.Parse(Console.ReadLine());
    
double all_of_them = shield + paint + distributor_for_paint + 2 * 1.50 + paint * 0.1 + 0.40;
    
double workers = (all_of_them * 0.3) * hours;
    
double final = workers + all_of_them;
    
Console.WriteLine(final);
