string line = Console.ReadLine();
while(line != "#")
{
    string newLine = "";
    for (int i = line.Length - 1; i >= 0; i--)
    {
        newLine += line[i];
    }
    Console.WriteLine(newLine.Trim());
    line = Console.ReadLine();
}