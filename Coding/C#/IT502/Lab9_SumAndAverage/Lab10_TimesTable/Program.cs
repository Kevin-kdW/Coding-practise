int line = int.Parse(Console.ReadLine());
while (line != 999)
{
    try
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} times {line} is {i * line}");
        }
        line = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("Das not right. Do it again");
        int.TryParse(Console.ReadLine(), out line);
    }
}