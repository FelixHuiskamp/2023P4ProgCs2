namespace ListOpdracht
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> birds = new List<string>() { "ui", "kraai", "hond", "papegaai"};
          //  totalElements = birds.Count;
            List<string> birds2 = new List<string>() { "meeuw", "duif" };
            birds.AddRange(birds2);
            birds.Remove("hond");
            for (int i = 0; i < birds.Count; i++)
            {
                Console.WriteLine(birds[i]);

            }


        }
    }
}
