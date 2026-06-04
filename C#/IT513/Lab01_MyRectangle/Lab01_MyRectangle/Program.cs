using Lab01_MyRectangle;

string line = (Console.ReadLine());
while (line != "#")
{
    try
    {
        string[] parts = line.Split(",");
        double part1 = double.Parse(parts[0]);
        double part2 = double.Parse(parts[1]);
        MyRectangle rect = new MyRectangle(part1, part2);
        Console.WriteLine(rect);
        Console.WriteLine($"Perimeter: {rect.CalcPerimeter():0.0}");
        Console.WriteLine($"Area: {rect.CalcArea():0.0}");
        Console.WriteLine("--------------------");
        line = Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("No, not right.");
        line = Console.ReadLine();
    }
}