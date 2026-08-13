Console.WriteLine("Lab 25");
int line = int.Parse(Console.ReadLine());
string[] names = new string[line];
int count = 0;
while (count < line)
{
    string name = Console.ReadLine();
    names[count] = name;
    count++;
}
Array.Sort(names);
foreach (string item in names)
{
    Console.WriteLine(item);
}