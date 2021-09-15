using System;
using System.Collections.Generic;

namespace tarsalgo
{
    class Program
    {

        List<Event> events = new List<Event>();
        Dictionary<int, Entity> entities = new Dictionary<int, Entity>();
        Dictionary<int, TimeStamp> timeStamps = new Dictionary<int, TimeStamp>();

        static void Main(string[] args)
        {
            processFile(@"ajto.txt");

            Console.WriteLine("2. feladat");
            Console.WriteLine("Az első belépő: " + "");
            Console.WriteLine("Az utolsó belépő: " + "");
            Console.WriteLine("");

            /*writeEntityAndNumOfEventsToFile();

            Console.WriteLine("");
            Console.WriteLine("4. feladat");
            Console.WriteLine("A végén a társalgóban voltak: ");
            Dictionary<int, Entity> entitiesStillIn = findEntitiesStillIn()
                Console.WriteLine("");*/

            Console.WriteLine("Hello World!");
        }

        private static void processFile(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");
        
            foreach (string line in lines)
            {
                Event event(line);
                events.add(event);
            }
        }
    }
}
