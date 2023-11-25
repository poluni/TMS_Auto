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
                    reoplacedLine = line.Replace("test", "testing");
                    foreach (char symbol in reoplacedLine)
                    {
                        if (Char.IsDigit(symbol))
                        {
                            replacedLine = reoplacedLine.Replace(symbol, new char());
                        }
                    }
                }
                Console.WriteLine(reoplacedLine);
            }
        }
    }
}