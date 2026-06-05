using System.Collections;

namespace Lab33_CountingNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("502 Lab 33");
            ArrayList names = LoadNames(@"names.txt");
            CountNames(names);
        }

        static ArrayList LoadNames(string path)
        {
            ArrayList names = new ArrayList();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    names.Add(line.Trim());
                }
            }
            return names;
        }

        static void CountNames(ArrayList names)
        {
            int maryCount = 0;
            int joeCount = 0;
            int anneCount = 0;

            foreach (var name in names)
            {
                if (name.Equals("Mary")) maryCount++;
                else if (name.Equals("Joe")) joeCount++;
                else if (name.Equals("Anne")) anneCount++;
            }

            Console.WriteLine($"Mary: {maryCount}\nJoe: {joeCount}\nAnne: {anneCount}");
        }
    }
}