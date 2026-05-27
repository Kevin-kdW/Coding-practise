Console.WriteLine("Lab23");
string line = Console.ReadLine();
while(line != "#")
{
    try
    {
        int a = 0;
        int b = 0;
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == 'A' || line[i] == 'a') a++;
            else if (line[i] == 'B' || line[i] == 'b') b++;
        }
        Console.WriteLine($"A: {a} B: {b}");
        line = Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Das not right");
        line = Console.ReadLine();
    }
}
