namespace Task3;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> weatherDictionary = InizializeweatherDictionary();

        Console.Write("Введите слово на русском (раздел Погода): ");
        string russianWord = Console.ReadLine();

        TranslateToEnglish(russianWord, weatherDictionary);


        Dictionary<string, string> InizializeweatherDictionary()
        {
            Dictionary<string, string> weatherDictionary = new Dictionary<string, string>();
            weatherDictionary.Add("Пасмурно", "Dull");
            weatherDictionary.Add("Солнечно", "Sunny");
            weatherDictionary.Add("Туман", "Fog");
            weatherDictionary.Add("Дождь", "Rain");
            weatherDictionary.Add("Ветер", "Wind");
            weatherDictionary.Add("Ураган", "Hurricane");
            weatherDictionary.Add("Шторм", "Storm");
            weatherDictionary.Add("Слякоть", "Slush");
            weatherDictionary.Add("Снег", "Snow");
            weatherDictionary.Add("Ливень", "Rainfall");
            return weatherDictionary;
        }

        void TranslateToEnglish(string russianWord, Dictionary<string, string> weatherDictionary){
            string value = "";
            if (weatherDictionary.TryGetValue(russianWord, out value))
            {
                Console.WriteLine($"Перевод слова \"{russianWord}\" на английский: {value}");

            }
            else Console.WriteLine($"Перевода слова \"{russianWord}\" в словаре нет ") ;
        }
    }
}