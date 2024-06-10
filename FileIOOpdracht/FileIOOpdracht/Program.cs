namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("leesdezefile.txt");
            foreach (string line in content)
            {
                Console.WriteLine(line);
            }


            File.WriteAllText("mijnnieuwefile.txt","hello");
            File.AppendAllText("mijnnieuwefile.txt", "hello2");
            Directory.CreateDirectory("output"); 


        }
    }
}
