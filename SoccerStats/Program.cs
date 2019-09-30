using System;
using System.IO;

namespace SoccerStats
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var filename = Path.Combine(directory.FullName, "data.txt");
            var file = new FileInfo(filename);
            if(file.Exists)
            {
                using(var reader = new StreamReader(file.FullName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());
                }
            }
        }
    }
}
