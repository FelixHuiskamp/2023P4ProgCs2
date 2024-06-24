using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
   
    internal class ConsoleMonFactory
    {
        internal void load(string datafile)
        {
            string[] lines = File.ReadAllLines (datafile);
            
            foreach(string line in lines)
            {

                string[] typeSplit = line.Split ('|');
                string[] consoleMonData = typeSplit[0].Split (",");
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                dataMon.health = int.Parse(consoleMonData[2]);
                dataMon.energy = int.Parse(consoleMonData[4]);
                
                Console.WriteLine(line);
                Console.WriteLine(dataMon.name);
            }
            
        } 

        internal void LoadJson(string datafile)
        {
            string json = File.ReadAllText (datafile);
            Console.WriteLine (json);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
        }

    }
}
