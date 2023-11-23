// Theme 3 "Strings". Task 1.

using System.Reflection.PortableExecutable;

namespace TMS_Auto
{
    static class Task31
    {
        static void Main(string[] args)
        {
            String path = @"D:\git-auto\TMS_Auto\Task31\data.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = String.Empty; ;
                while ((line = reader.ReadLine()) != null)
                { 

                }
                Console.WriteLine(line);
            }
        }
    }
}