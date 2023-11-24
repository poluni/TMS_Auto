// Theme 3 "Strings". Task 4.

namespace TMS_Auto
{
    static class Task34
    {
        static void Main(string[] args)
        {
            string inputLine = "Плохой день.";
            string removeWord = "плохой";
            string insertWord = "Хороший";

            int positionOfRemove = inputLine.Length - removeWord.Length;
            string substringWithoutRemoveWord = inputLine.Substring(positionOfRemove);

            int positionOfInsert = inputLine.IndexOf(removeWord, StringComparison.OrdinalIgnoreCase);
            string substringWithInsertWord = substringWithoutRemoveWord.Insert(positionOfInsert, insertWord);

            int positionOfPoint = substringWithInsertWord.LastIndexOf('.');
            string substringWithInsertPunctuation = substringWithInsertWord.Insert(positionOfPoint, new String('!', 9));

            int positionOfSign = substringWithInsertPunctuation.LastIndexOf('!');
            substringWithInsertPunctuation = substringWithInsertPunctuation.Remove(positionOfSign, 1);
            string finalString = substringWithInsertPunctuation.Insert(positionOfSign, "?");

            Console.WriteLine(finalString);
        }
    }
}
