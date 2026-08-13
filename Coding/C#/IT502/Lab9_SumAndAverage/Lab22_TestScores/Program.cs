string line = Console.ReadLine();
while (line != "#")
{
    string[] parts = line.Split(",");
    string lastName = parts[0];
    string firstName = parts[1];
    int total = 0;
    for (int i = 2; i < parts.Length; i++)
    {
        if (int.TryParse(parts[i], out int number))
        {
            total += number;
        }
    }
    Console.WriteLine($"{firstName} {lastName} {total}");
    line = Console.ReadLine();
}