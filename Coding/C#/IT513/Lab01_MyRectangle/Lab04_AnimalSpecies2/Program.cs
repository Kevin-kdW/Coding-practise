namespace Lab04_AnimalSpecies2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("513 - Lab 04");
            List<Animal> animals = GetData();
            string line = Console.ReadLine();
            while (line != "#")
            {
                foreach (Animal animal in animals)
                {
                    if (line == animal.Classification)
                    {
                        Console.WriteLine(animal);
                    }
                }
                line = Console.ReadLine();
            }
        }

        static List<Animal> GetData()
        {
            List<Animal> animals = new List<Animal>();
            using (StreamReader reader = new StreamReader(@"animals.txt"))
            {
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line == "") continue;
                    Animal animal = AnimalFactory.CreateAnimal(line);
                    if (animal != null)
                    {
                        animals.Add(animal);
                    }
                }
                return animals;
            }//using
        }
    }
}
