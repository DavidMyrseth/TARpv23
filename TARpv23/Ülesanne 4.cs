using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.AddEntry("Tallinn", "Harju");
            dictionary.AddEntry("Tartu", "Tartu");
            dictionary.AddEntry("Narva", "Ida-Viru");

            bool running = true;
            while (running)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Получить регион по столице");
                Console.WriteLine("2. Получить столицу по региону");
                Console.WriteLine("3. Добавить новую запись");
                Console.WriteLine("4. Тестировать знания");
                Console.WriteLine("5. Выход");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите столицу: ");
                        string capital = Console.ReadLine();
                        string regionByCapital = dictionary.GetRegionByCapital(capital);
                        Console.WriteLine(regionByCapital ?? "Столица не найдена.");
                        break;
                    case "2":
                        Console.Write("Введите регион: ");
                        string region = Console.ReadLine();
                        string capitalByRegion = dictionary.GetCapitalByRegion(region);
                        Console.WriteLine(capitalByRegion ?? "Регион не найден.");
                        break;
                    case "3":
                        Console.Write("Введите столицу: ");
                        string newCapital = Console.ReadLine();
                        Console.Write("Введите регион: ");
                        string newRegion = Console.ReadLine();
                        dictionary.AddEntry(newCapital, newRegion);
                        Console.WriteLine("Запись добавлена.");
                        break;
                    case "4":
                        dictionary.TestKnowledge();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
    }

    class Dictionary
    {
        private readonly Dictionary<string, string> capitalToRegion = new();
        private readonly Dictionary<string, string> regionToCapital = new();

        public void AddEntry(string capital, string region)
        {
            if (!capitalToRegion.ContainsKey(capital))
            {
                capitalToRegion[capital] = region;
                regionToCapital[region] = capital;
            }
        }

        public string GetRegionByCapital(string capital)
        {
            return capitalToRegion.TryGetValue(capital, out var region) ? region : null;
        }

        public string GetCapitalByRegion(string region)
        {
            return regionToCapital.TryGetValue(region, out var capital) ? capital : null;
        }

        public void TestKnowledge()
        {
            Random rand = new Random();
            List<string> capitals = new List<string>(capitalToRegion.Keys);
            List<string> regions = new List<string>(regionToCapital.Keys);

            int correctAnswers = 0;
            int totalQuestions = 5; // Количество вопросов для теста

            for (int i = 0; i < totalQuestions; i++)
            {
                if (rand.Next(2) == 0) // Выбираем случайно, спрашивать про столицу или регион
                {
                    string randomCapital = capitals[rand.Next(capitals.Count)]; // Вопрос о столице
                    Console.Write($"Какой регион является столицей {randomCapital}? ");
                    string answer = Console.ReadLine();
                    if (answer.Equals(capitalToRegion[randomCapital], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Правильно!");
                        correctAnswers++;
                    }
                    else
                    {
                        Console.WriteLine($"Неправильно. Правильный ответ: {capitalToRegion[randomCapital]}");
                    }
                }
                else
                {
                    string randomRegion = regions[rand.Next(regions.Count)]; // Вопрос о регионе
                    Console.Write($"Какая столица у региона {randomRegion}? ");
                    string answer = Console.ReadLine();
                    if (answer.Equals(regionToCapital[randomRegion], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Правильно!");
                        correctAnswers++;
                    }
                    else
                    {
                        Console.WriteLine($"Неправильно. Правильный ответ: {regionToCapital[randomRegion]}");
                    }
                }
            }

            double score = (double)correctAnswers / totalQuestions * 100;
            Console.WriteLine($"Тест завершен. Ваш результат: {score}%");
        }
    }
}
