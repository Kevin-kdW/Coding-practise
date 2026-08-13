string line = Console.ReadLine();
while (line != "#")
{
    int count = 0;
    foreach (string num in line.Split(" "))
    {
        if (int.TryParse(num, out int number))
        {
            count += number;
        }
    }
    Console.WriteLine(count);
    line = Console.ReadLine();
}
