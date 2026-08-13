namespace Lab34_ShoppingList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("502 Lab 34 - use Dictionary (Hashmap)");
            using (StreamReader reader = new StreamReader(@"pricelist.txt"))
            {
                string line = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    GetData(line);
                }
            }
        }
        public static Dictionary<string,int> GetData()
        {
            Dictionary<string, int> shoppingList = new Dictionary<string, int>();
            shoppingList.Add(line);
            return shoppingList;
        }//Dict
    }
}
