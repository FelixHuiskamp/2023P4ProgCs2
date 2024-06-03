namespace FIleDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\jedif\OneDrive\Documenten\ma\Periode 4 PROG C#\2023P4ProgCs2");


           DirectoryInfo[] directoryInfos = dir.GetDirectories();
            for (int i = 0; i < directoryInfos.Length; i++)
            {
                Console.WriteLine(directoryInfos[i].FullName);
            }

            
        }
    }
}
