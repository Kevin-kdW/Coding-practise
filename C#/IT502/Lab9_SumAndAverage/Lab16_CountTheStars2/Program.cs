string line = Console.ReadLine();
while (line != "#")
{
    int count = 0;
    foreach (char c in line)
    {
        if (c == '!') break;
        else if (c == '*') count++;
    }
    Console.WriteLine(count);
    line = Console.ReadLine();
}