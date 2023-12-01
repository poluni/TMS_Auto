// Theme 3 "Strings". Task 1.

using System.Reflection.PortableExecutable;

namespace TMS_Auto
{
    static class Task31
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo(@"D:\git-auto\TMS_Auto\Task31\data.txt");
            using (StreamReader reader = fileInfo.OpenText())
            {
                string replacedLine = String.Empty;
                string line = String.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    replacedLine = line.Replace("test", "testing");
                    foreach (char symbol in replacedLine)
                    {
                        if (Char.IsDigit(symbol))
                        {
                            replacedLine = replacedLine.Replace(symbol, new char());
                        }
                    }
                }
                Console.WriteLine(replacedLine);
            }
        }
    }
}