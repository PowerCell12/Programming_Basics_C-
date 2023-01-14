double kv_metra = double.Parse(Console.ReadLine());

double kv_metra_with_money = kv_metra * 7.61; 

double percentage  = kv_metra_with_money * 18 / 100;

double final = kv_metra_with_money - percentage;

Console.WriteLine($"The final price is: {final} lv.");

Console.WriteLine($"The discount is: {percentage} lv.");
    
