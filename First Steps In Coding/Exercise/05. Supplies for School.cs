double pens = double.Parse(Console.ReadLine()) * 5.80;

double marks = double.Parse(Console.ReadLine()) * 7.20;
    
double preparation = double.Parse(Console.ReadLine()) * 1.20;
    
double percentage = double.Parse(Console.ReadLine()) / 100;
    
double all_of_them = pens + marks + preparation;
    
double With_the_percentages = all_of_them - all_of_them * percentage;
    
Console.WriteLine(With_the_percentages);
