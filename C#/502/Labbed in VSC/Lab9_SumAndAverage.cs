class Lab9_SumAndAverage
{
    public static void Run()
    {
        int sum = 0;
        int count = 0;
        int line = int.Parse(Console.ReadLine());
        while (line != 999)
        {
            sum += line;
            count++;
            line = int.Parse(Console.ReadLine());
        }
        Console.Write($"Sum: {sum}\nAverage: {sum / count}");
    }
}