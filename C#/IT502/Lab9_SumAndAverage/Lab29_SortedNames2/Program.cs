using System.Collections;
using System.Globalization;

Console.WriteLine("Lab 29");
string line = Console.ReadLine();
ArrayList names = new ArrayList();
while (line != "#")
{
    names.Add(line);
    line = Console.ReadLine();
}
names.Sort();
foreach (string item in names)
{
    Console.WriteLine(item);
}