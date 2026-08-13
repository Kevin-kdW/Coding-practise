namespace Lab03_AnimalSpecies1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("513 Lab03\n");

            using (StreamReader reader = new StreamReader(@"animals.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(",");
                    if (line == "") continue;
                    string part1 = parts[0];
                    int part2 = int.Parse(parts[1]);
                    string part3 = parts[2];
                    bool part4 = bool.Parse(parts[3]);
                    Animal animal = new Animal(part1,part2,part3,part4);
                    Console.WriteLine(animal);
                }
            }
        }
    }
}
