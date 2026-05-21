class Lab10_TimesTable
{
    public static void Run()
    {
        int line = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} times {line} is {i * line}");
        }
        
    }
}


