string line = Console.ReadLine();
while (line != "#")
{
    try
    {
        string[] parts = line.Split(' ');
        string name1 = parts[0];
        int score1 = int.Parse(parts[1]);
        string name2 = parts[2];
        int score2 = int.Parse(parts[3]);
        if (score1 > score2)
            Console.WriteLine($"{name1} {score1} {name2} {score2}");
        else if (score2 > score1)
            Console.WriteLine($"{name2} {score2} {name1} {score1}");
        else if (score1 == score2)
            Console.WriteLine($"{name1} {score1} {name2} {score2}");
    }
    catch (Exception e)
    {
        Console.WriteLine("Das not right.");
    }
    line = Console.ReadLine();
}