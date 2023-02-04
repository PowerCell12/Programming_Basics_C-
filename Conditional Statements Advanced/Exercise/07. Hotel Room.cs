string mounth = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());
double studio = 0;
double apartment = 0;
int percentage = 0;

switch (mounth)
{
    case "May":
    case "October":
     studio = 50;
     apartment = 65;
      if (7 < nights && nights < 15)
      {
        percentage = 5;
      }
      else if (nights > 14)
      {
        percentage = 30;
      }
      break;

    case "June":
    case "September":
      studio = 75.20;
      apartment = 68.70;
      if (nights > 14)
      {
        percentage = 20;
      }
      break;

    
    case "July":
    case "August":
      studio = 76;
      apartment = 77;
      break;
}

double percentage_apartemnt = 0;
if (nights > 14)
{
   percentage_apartemnt = 10;
}
double apartment1 = apartment * nights;
double studio1 = studio * nights; 

double final_Apartment = apartment1 - (apartment1 * percentage_apartemnt / 100);
double final_studio = studio1 - (studio1 * percentage / 100);

Console.WriteLine($"Apartment: {final_Apartment:f2} lv.");
Console.WriteLine($"Studio: {final_studio:f2} lv.");
