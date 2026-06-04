namespace Lab05_DeweyClassificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("513 - Lab04");
            string line = Console.ReadLine();
            List<Dewey> deweySystem = GetData();
            while (line != "#")
            {
                string[] parts = line.Split(",");
                int num1 = int.Parse(parts[0]);
                int num2 = int.Parse(parts[1]);
                foreach (Dewey sentence in deweySystem)
                {
                    if(sentence.Code >= num1 && sentence.Code <= num2)
                    {
                        Console.WriteLine(sentence);
                    }
                }
                line = Console.ReadLine();
            }
        }

        public static List<Dewey> GetData()
        {
            List<Dewey> dewey = new List<Dewey>();
            using (StreamReader reader = new StreamReader(@"dewey.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line == "") continue;
                    Dewey dew = FactoryDewey.CreateDewey(line);
                    dewey.Add(dew);
                }
                return dewey;
            }
        }
    }
}
