// Theme 3 "Strings". Task 2.

using System.Reflection.PortableExecutable;

namespace TMS_Auto
{
    static class Task32
    {
        static void Main(string[] args)
        {
            String path = @"D:\git-auto\TMS_Auto\Task32\data.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = String.Empty;
                string[] words = new string[] { };
                while ((line = reader.ReadLine()) != null)
                {
                    words = line.Split(' ');
                }
                string str_final = string.Join("\" \"", words);
                Console.WriteLine($"\"{str_final}\"");
            }
        }
    }
}