namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringsplit.txt");
            string[] keyvvalue = content.Split(":");
            foreach (string key in keyvvalue)
            {
                Console.WriteLine(content);
            }
          //  keyvvalue[1]
            string[] keyvvalue2 = content.Split(",");
        }
    }
}
