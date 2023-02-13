string name = Console.ReadLine();
string password = Console.ReadLine();
string passwordtried = Console.ReadLine();

while (passwordtried != password)
{
    passwordtried = Console.ReadLine();
}

Console.WriteLine($"Welcome {name}!");
