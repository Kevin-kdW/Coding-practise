int line = int.Parse(Console.ReadLine());
int count = 0;
int sum = 0;
while (line != 999)
{
    try
    {
        count++;
        sum += line;
        line = int.Parse(Console.ReadLine());
    } 
    catch (Exception e)
    {
        Console.WriteLine("Das not right, try again");
    }
}
Console.WriteLine($"Sum: {sum}\nAverage: {sum/(double)count:0.00}");