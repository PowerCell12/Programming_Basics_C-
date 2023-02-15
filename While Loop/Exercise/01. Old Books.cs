string favbook = Console.ReadLine();
string book = Console.ReadLine();
int counter = 0;

while (book != "No More Books" && book != favbook)
{
    counter += 1;
    book = Console.ReadLine();
}


if (book == "No More Books")
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {counter} books.");
}
else
{
    Console.WriteLine($"You checked {counter} books and found it.");
}
