string  text = Console.ReadLine();
int value = 0;

for (int i = 0; i < text.Length; i++)
{
    string current_number = Char.ToString(text[i]);
    if (current_number == "a")
    {
        value += 1;
    }

    if (current_number == "e")
    {
        value += 2;
    }
    
    if (current_number == "i")
    {
        value += 3;
    }
    
    if (current_number == "o")
    {
        value += 4;
    }
    
    if (current_number == "u")
    {
        value += 5;
    }
}


Console.WriteLine(value);
