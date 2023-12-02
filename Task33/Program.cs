// Theme 3 "Strings". Task 3.

using System.Reflection.PortableExecutable;

namespace TMS_Auto
{
    static class Task33
    {
        static void Main(string[] args)
        {
            String path = @"D:\git-auto\TMS_Auto\Task33\input_data.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = String.Empty;
                string[] words = new string[] { };
                while ((line = reader.ReadLine()) != null)
                {
                    words = line.Trim().Split("abc");
                }
                string str_1 = words[0];
                string str_2 = words[1];
                Console.WriteLine($"Символы до строки \"abc\": {str_1}");
                Console.WriteLine($"Символы после строки \"abc\": {str_2}");
            }
        }
    }
}