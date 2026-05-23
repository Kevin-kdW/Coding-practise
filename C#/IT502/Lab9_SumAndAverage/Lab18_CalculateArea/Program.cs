string line = Console.ReadLine();

while (line != "#")
{
    string[] parts = line.Split(" ");
    string code = parts[0];
    double initialDouble = double.Parse(parts[1]);
    if (code == "C")
    {
        //do something
        double squared = Math.PI * initialDouble * initialDouble;
        Console.WriteLine($"{squared: 0.0}");
    }
    else if (code == "S")
    {
        //do something
        double timesItself = initialDouble * initialDouble;
        Console.WriteLine(timesItself);
    }
    else if (code == "R")
    {
        double rect = double.Parse(parts[2]);
        //do something
        Console.WriteLine(initialDouble * rect);
    }
    else if (code == "T")
    {
        double tri = double.Parse(parts[2]);
        //do something
        Console.WriteLine(initialDouble * tri);
    }
    line = Console.ReadLine();
    
}
