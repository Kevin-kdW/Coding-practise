string line = Console.ReadLine();

while (line != "#")
{
    try
    {
        string[] parts = line.Split(" ");
        string code = parts[0];
        double initialDouble = double.Parse(parts[1]);
        if (code == "C" || code == "c")
        {
            //do something
            double squared = Math.PI * initialDouble * initialDouble;
            Console.WriteLine($"{squared: 0.0}".Trim());
        }
        else if (code == "S" || code == "s")
        {
            //do something
            double timesItself = initialDouble * initialDouble;
            Console.WriteLine($"{timesItself:0.0}");
        }
        else if (code == "R" || code == "r")
        {
            double rect = double.Parse(parts[2]);
            //do something
            Console.WriteLine($"{initialDouble * rect:0.0}");
        }
        else if (code == "T" || code == "t")
        {
            double tri = double.Parse(parts[2]);
            //do something
            Console.WriteLine(($"{((initialDouble / 2) * tri):0.0}"));
        }
        line = Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Das not right. Do it again");
        line = Console.ReadLine();
    }
}

    