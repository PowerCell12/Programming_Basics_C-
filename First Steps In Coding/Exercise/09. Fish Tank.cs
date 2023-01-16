double dulshina = double.Parse(Console.ReadLine());

double shirochina = double.Parse(Console.ReadLine());
    
double vishochina = double.Parse(Console.ReadLine());
    
double percentage = double.Parse(Console.ReadLine()) / 100;
    
double Obem = dulshina * shirochina * vishochina;
    
double obem_v_litri = Obem * 0.001;
    
double litri_needed = obem_v_litri * (1 - percentage);
    
Console.WriteLine(litri_needed);
