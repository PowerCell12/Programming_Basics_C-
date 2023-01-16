double yearly_price = double.Parse(Console.ReadLine());

double shoes = yearly_price * 0.6;
    
double ekip = shoes * 0.8;
    
double ball = ekip * 0.25;
    
double  acsesories = ball * 0.20;
    
double final = yearly_price + shoes + ekip + ball + acsesories;
    
Console.WriteLine(final);
