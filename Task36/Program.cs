// Theme 3 "Strings". Task 6.
using System.Text;

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
                while ((line = reader.ReadLine()) != null)
                {
                    StringBuilder sb = new StringBuilder(line, 100);
                    if (sb.Length <= 100)
                    {
                        string word = sb.Replace("\t", " ").Replace("  ", " ").ToString();
                        Console.WriteLine($"Нормализованная строка: {word}");
                    }
                    else Console.WriteLine($"В строке больше 100 символов.");
                }
            }
        }
    }
}