// Theme 3 "Strings". Task 5.

using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using TMS_Auto;

namespace TMS_Auto
{
    static class Task35
    {
        class Document
        {
            public static void OutputFirstNumbersBlocks(string inputLine)
            {
                string pattern = @"\d{4}";
                MatchCollection matches = Regex.Matches(inputLine, pattern);
                foreach (Match matchItem in matches)
                {
                    string number = matchItem.Groups[0].Value;
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }

            public static void OutputLineLetterReplacedByStars(string inputLine)
            {
                string pattern = @"[a-zA-Z]{3}";
                string resultLine = Regex.Replace(inputLine, pattern, new String('*', 3));
                Console.WriteLine(resultLine);
            }

            public static void OutputOnlyLettersToLower(string inputLine)
            {
                string pattern = @"[a-zA-Z]{3}|(?:[a-z])";
                MatchCollection matches = Regex.Matches(inputLine, pattern);
                int count = 0;
                foreach (Match matchItem in matches)
                {
                    string result = matchItem.Groups[0].Value.ToLower();
                    count++;
                    Console.Write(result);
                    if (matches.Count != count)
                    {
                        Console.Write("/");
                    }
                    else Console.WriteLine();
                }
            }

            public static void OutputOnlyLettersToUpper(string inputLine)
            {
                string pattern = @"[a-zA-Z]{3}|(?:[a-z])";
                MatchCollection matches = Regex.Matches(inputLine, pattern);
                int count = 0;
                StringBuilder sb = new StringBuilder();
                Console.Write("Letters:");
                foreach (Match matchItem in matches)
                {
                    sb.Append(matchItem.Groups[0].Value.ToUpper());
                    count++;
                    Console.Write(sb);
                    if (matches.Count != count)
                    {
                        Console.Write("/");
                    }
                    else Console.WriteLine();
                }
            }

            public static void OutputIfContainABC(string inputLine)
            {
                if (inputLine.Contains("abc", StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine($"В строке {inputLine} содержится последовательность \"abc\"");
                else
                    Console.WriteLine($"В строке {inputLine} нет последовательности \"abc\"");

            }

            public static void OutputIfStartsWithMask(string inputLine)
            {
                if (inputLine.StartsWith("555"))
                    Console.WriteLine($"Строка {inputLine} начинается с \"555\"");
                else
                    Console.WriteLine($"Строка {{inputLine}} не начинается с \"555\"");

            }

            public static void OutputIfEndsWithMask(string inputLine)
            {
                if (inputLine.EndsWith("1a2b"))
                    Console.WriteLine($"Строка {inputLine} заканчивается на \"1a2b\"");
                else
                    Console.WriteLine($"Строка {inputLine} не заканчивается на \"1a2b\"");

            }
        }


        static void Main(string[] args)
        {
            String path = @"D:\git-auto\TMS_Auto\Task35\document_data.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = String.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    Document.OutputFirstNumbersBlocks(line);
                    Document.OutputLineLetterReplacedByStars(line);
                    Document.OutputOnlyLettersToLower(line);
                    Document.OutputOnlyLettersToUpper(line);
                    Document.OutputIfContainABC(line);
                    Document.OutputIfStartsWithMask(line);
                    Document.OutputIfEndsWithMask(line);
                }
            }
        }
    }
}