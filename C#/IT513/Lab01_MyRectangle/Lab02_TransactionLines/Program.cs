namespace Lab02_TransactionLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("513 - Lab02");
            string line = Console.ReadLine();
            while (line != "#")
            {
                string[] parts = line.Split(",");
                string name = parts[0];
                double cost = double.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);
                Transaction transaction = new Transaction(name,cost,quantity);
                Console.WriteLine(transaction);
                line = Console.ReadLine();
            }
        }
    }
}
