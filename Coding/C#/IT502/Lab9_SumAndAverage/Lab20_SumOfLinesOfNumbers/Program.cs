string line = (Console.ReadLine());
while (line != "#")
{
    try
    {
        if (string.IsNullOrWhiteSpace(line))
        {
            Console.WriteLine(0);
            line = Console.ReadLine();
        }
        else
        {
            int count = 0;
            foreach (string numbers in line.Split(" "))
            {
                count += int.Parse(numbers);
            }
            Console.WriteLine(count);
            line = Console.ReadLine();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Das not right.");
        line = (Console.ReadLine());
    }
}