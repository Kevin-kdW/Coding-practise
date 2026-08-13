using System.Collections;

Console.WriteLine("Lab 27");
double line = double.Parse(Console.ReadLine());
int count = 0;
double sum = 0;
ArrayList numbers = new ArrayList();
while (line != -1)
{
    numbers.Add(line);
    count++;
    sum += line;
    line = double.Parse(Console.ReadLine());
}
foreach (double item in numbers)
{
    //Console.WriteLine(sum+=item);
    if (item > (sum/count)) Console.WriteLine($"{item:0.00} ABOVE AVERAGE");
    else if (item < (sum / count)) Console.WriteLine($"{item:0.00} BELOW AVERAGE");
}