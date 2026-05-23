string line = Console.ReadLine();
while (line != "#")
{
    int count = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i] == '*')
        {
            count++;
        }
    }
    Console.WriteLine(count);
    line = Console.ReadLine();
}