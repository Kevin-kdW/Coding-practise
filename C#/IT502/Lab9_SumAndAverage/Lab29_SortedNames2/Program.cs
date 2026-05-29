using System.Collections;

Console.WriteLine("Lab 29");
string line = Console.ReadLine();
ArrayList names = new ArrayList(200);
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