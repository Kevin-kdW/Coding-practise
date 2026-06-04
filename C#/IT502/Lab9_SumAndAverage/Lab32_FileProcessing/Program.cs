namespace Lab32_FileProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"raw.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(" ");
                    string name = parts[0];

                    // Get the scores (everything after the name)
                    int[] scores = parts.Skip(1).Select(int.Parse).ToArray();
                    Array.Sort(scores);
                    Array.Reverse(scores); // highest first
                    Console.WriteLine($"{name} {scores[0]} {scores[1]} {scores[2]}");
                }
            }
        }
    }
}
