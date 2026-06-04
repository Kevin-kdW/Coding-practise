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
                    RecursedNames(line);
                }
                //Console.WriteLine($"");
            }
        }
        static void RecursedNames(string line)
        {
            ArrayList names = new ArrayList();
            foreach (string person in names)
            {
                names.Add(person);
            }
            Console.WriteLine(names);
            line = Console.ReadLine();
        }
    }
}
