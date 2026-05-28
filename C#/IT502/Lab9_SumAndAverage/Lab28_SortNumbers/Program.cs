using System.Collections;

Console.WriteLine("Lab 28");
int line = int.Parse(Console.ReadLine());
ArrayList numbers = new ArrayList();
while (line != -1)
{
    numbers.Add(line);
    line = int.Parse(Console.ReadLine());
}
numbers.Sort();
foreach (int item in numbers)
{
    Console.WriteLine(item);
}