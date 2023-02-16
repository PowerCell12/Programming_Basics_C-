int dulshina = int.Parse(Console.ReadLine());
int shirochina = int.Parse(Console.ReadLine());

int how_many = dulshina * shirochina;
string command = "";


while (how_many > 0)
{
    command =  Console.ReadLine();

    if (command == "STOP")
    {
        break;
    }

    int command1 = int.Parse(command);
    
    how_many = how_many - command1;
}

if (how_many > -1)
{
    Console.WriteLine($"{how_many} pieces are left.");
}
else if (how_many < 0)
{
    int pieces_needed = Math.Abs(how_many);
    Console.WriteLine($"No more cake left! You need {pieces_needed} pieces more.");
}
