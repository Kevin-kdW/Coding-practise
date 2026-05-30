using System.Collections;

namespace Lab31_HorizontalNameSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 31");
            string line = Console.ReadLine();
            while (line != "#")
            {
                SortNames(line);
                line = Console.ReadLine();
            }
        }

        static void SortNames(string name)
        {
            ArrayList names = new ArrayList();
            string[] parts = name.Split(",");
            foreach (string item in parts)
            {
                names.Add(item);
            }
            names.Sort();
            Console.WriteLine(string.Join(",", names.ToArray()));
        }
    }
}
