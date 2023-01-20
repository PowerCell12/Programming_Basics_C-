string type = (Console.ReadLine());

if(type == "square")
{
  float number = float.Parse(Console.ReadLine());
  Console.WriteLine(number * number);
}
if(type == "rectangle")
{
  float side = float.Parse(Console.ReadLine());
  float side2 = float.Parse(Console.ReadLine());
  Console.WriteLine(side * side2);
}
if(type == "circle")
{
  float radius = float.Parse(Console.ReadLine());
  Console.WriteLine(radius * radius * Math.PI);
}
if(type == "triangle")
}
  float side3 = float.Parse(Console.ReadLine());
  float hight = float.Parse(Console.ReadLine());
  Console.WriteLine((side3 * hight) / 2);
}
