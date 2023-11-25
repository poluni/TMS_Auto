// Theme 3 "Strings". Task 7.

using System.Text;

namespace TMS_Auto
{
    static class Task37
    {
        static void Main(string[] args)
        {
            String path = @"D:\git-auto\TMS_Auto\Task37\input_data.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = String.Empty;
                string finalString = String.Empty;
                string[] words = new string[] { };
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length < 100)
                    {
                        StringBuilder sb = new StringBuilder(line, 100);
                        string normalizedString = sb.Replace("\t", " ").Replace("  ", " ").ToString();
                        words = normalizedString.Split(" ");
                        if (words.GetLength(0) < 20)
                        {
                            bool isWrongWordLength = true;
                            foreach (string word in words)
                            {
                                if (word.Length > 10)
                                {
                                    isWrongWordLength = true;
                                    Console.WriteLine($"В строке есть слова из более чем 10 символов.");
                                    break;
                                }
                                else
                                {
                                    isWrongWordLength = false;
                                }
                            }
                            if (!isWrongWordLength)
                            {
                                Array.Sort(words);
                                finalString = string.Join(" ", words);
                                Console.WriteLine($"Отсортированная строка: {finalString}");
                            }
                        }
                        else Console.WriteLine($"Число слов в строке превышает 20.");
                    }
                    else Console.WriteLine($"В строке больше 100 символов.");
                }
            }
        }
    }
}