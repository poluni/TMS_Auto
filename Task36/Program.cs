// Theme 3 "Strings". Task 6.

namespace TMS_Auto
{
    static class Task36
    {
        static void Main(string[] args)
        {
            String path = @"D:\git-auto\TMS_Auto\Task36\input_data.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = String.Empty;
                string word = String.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    word = line.Trim().Replace("\t", " ").Replace("  ", " ");
                }
                Console.WriteLine($"Нормализованная строка: {word}");
            }
        }
    }
}