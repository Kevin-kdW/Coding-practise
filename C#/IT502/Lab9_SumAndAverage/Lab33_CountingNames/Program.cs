using System.Collections;

namespace Lab33_CountingNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursion? NOT FINISHED
            Console.WriteLine("502 Lab 33");
            using (StreamReader reader = new StreamReader(@"names.txt"))
            {
                string line = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    Names(line);
                }
                //Console.WriteLine($"");
            }
        }
        static void Names(string line)
        {
            ArrayList names = new ArrayList();
            int maryCount = 0;
            int joeCount = 0;
            int anneCount = 0;
            names.Add(line);
            foreach (var name in names)
            {
                if (name == "Mary") maryCount++;
                else if (name == "Joe") joeCount++;
                else if (name == "Anne") anneCount++;
            }
            Console.WriteLine($"Mary: {maryCount}\nJoe: {joeCount}\nAnne: {anneCount}");
            line = Console.ReadLine();
        }
    }
}
