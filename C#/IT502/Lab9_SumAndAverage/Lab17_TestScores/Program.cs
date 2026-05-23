string line = Console.ReadLine();
while (line != "#")
{
    string[] parts = line.Split(',');
    string part1 = parts[0];
    string part2 = parts[1];
    try
    {
        int part3 = int.Parse(parts[2]);
        int part4 = int.Parse(parts[3]);
        int part5 = int.Parse(parts[4]);
        int part6 = int.Parse(parts[5]);
        Console.WriteLine($"{part2} {part1} {part3 + part4 + part5 + part6}");
    }
    catch (Exception e)
    {
        Console.WriteLine("Das not correct. Do it again");
    }
    line = Console.ReadLine();
}