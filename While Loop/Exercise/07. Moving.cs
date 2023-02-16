int shirochina = int.Parse(Console.ReadLine());
int dulshina = int.Parse(Console.ReadLine());
int high = int.Parse(Console.ReadLine());

int all = shirochina  * dulshina * high;
int boxes1 = 0;

while (boxes1 < all)
{
    string boxes = Console.ReadLine();

    if (boxes == "Done")
    {
        break;
    }

    int boxes2 = int.Parse(boxes);
    boxes1 += boxes2;
}

if (boxes1 <= all)
{
    int final = all - boxes1;
    Console.WriteLine($"{final} Cubic meters left.");
}
else
{
    int final  = boxes1 - all;
    Console.WriteLine($"No more free space! You need {final} Cubic meters more.");
}
