using System.Collections;

Console.WriteLine("Lab 30");
string line = (Console.ReadLine());
while (line != "#")
{
    ConvertToNums(line);
    line = Console.ReadLine();
}

static void ConvertToNums(string nums)
{
    ArrayList numbers = new ArrayList();
    string[] parts = nums.Split(' ');
    foreach (string part in parts)
    {
        if (int.TryParse(part, out int number))
        {
            numbers.Add(number);
        }
    }
    numbers.Sort();
    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }
}