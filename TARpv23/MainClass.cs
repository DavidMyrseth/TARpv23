using System; 
using System.Collections; 
using System.Collections.Generic;
using System.Drawing; 
using System.Text; 

namespace TARpv23_CSharp
{
    public class MainClass2 
    {
        public static void Main(string[] args)
        {
            Random random = new Random(); // Создание объекта Random для генерации случайных чисел

            Console.OutputEncoding = Encoding.UTF8; // Установка кодировки вывода в UTF-8

            // III.osa OOP - Работа с объектно-ориентированным программированием (OOP)
            List<Inimene> inimesed = new List<Inimene>(); // Создание списка объектов типа Inimene (людей)

            // Создание объектов типа Inimene с различными конструкторами и свойствами
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 352;
            inimene1.Pikkus = 200;
            inimene1.Kaal = 100;

            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            inimene2.Sugu = Sugu.Naissugu;
            inimene2.Pikkus = 200;
            inimene2.Kaal = 100;

            Inimene inimene3 = new Inimene("David", 18);

            // Добавление объектов в список
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina", 18)); // Добавление нового объекта в список напрямую

            // Вывод информации о каждом человеке в списке
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine($"{inimene.Nimi} on {inimene.Vanus} aastat vana");
            }

            // Создание объектов типа Auto с заданием регистрационного номера, цвета и владельца
            Auto auto1 = new Auto("681MRP", Color.Bisque, inimene1);
            Auto auto2 = new Auto("180ABC", Color.NavajoWhite, inimene2);
            Auto auto3 = new Auto("079TDI", Color.Red, inimene3);

            // Вызов метода KelleOmaAuto для объекта auto1
            auto1.KelleOmaAuto();

            // Создание словаря для хранения пар (машина, владелец)
            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();
            register.Add(auto1, inimene1); // Добавление в словарь первой пары
            register.Add(auto2, inimene2); // Добавление в словарь второй пары
            register.Add(auto3, inimene3); // Добавление в словарь третьей пары

            // Вывод регистрационного номера машины и имени владельца через цикл foreach
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key.RegNumber} - {item.Value.Nimi}");
            }

            // Другой способ вывода регистрационного номера машины и имени владельца через KeyValuePair
            foreach (KeyValuePair<Auto, Inimene> pair in register)
            {
                Console.WriteLine($"{pair.Key.RegNumber} - {pair.Value.Nimi}");
            }

            // II.OSA - работа со списками и словарями
            ArrayList arrayList = new ArrayList(); // Создание ArrayList - не типизированный список
            arrayList.Add("Esimene"); // Добавление первого элемента в ArrayList
            arrayList.Add("Teine"); // Добавление второго элемента в ArrayList
            arrayList.Add("Kolmas"); // Добавление третьего элемента в ArrayList

            // Запрос ввода от пользователя
            Console.WriteLine("Otsing: ");
            string vas = Console.ReadLine();

            // Проверка, если введенный элемент содержится в ArrayList
            if (vas != null && arrayList.Contains(vas))
            {
                Console.WriteLine("Otsitav element asub " + arrayList.IndexOf(vas) + ".kohal");
            }
            else
            {
                Console.WriteLine("Kokku oli " + arrayList.Count + " elementi, kuid otsitav puudub.");
            }

            // Очистка ArrayList и вставка новых элементов
            arrayList.Clear();
            arrayList.Insert(1, "Anna"); // Вставка элемента на вторую позицию
            arrayList.Insert(0, "Inna"); // Вставка элемента на первую позицию

            // I. Osa - работа с файлами и обработка исключений
            List<string> abc = new List<string>(); // Создание списка строк для хранения данных из файла
            try
            {
                // Чтение всех строк из файла и добавление их в список
                foreach (string rida in System.IO.File.ReadAllLines(@"..\..\..\ABC.txt"))
                {
                    abc.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Faili ei saa leida!"); // Обработка ошибки, если файл не найден
            }

            // Вывод содержимого списка abc на экран
            foreach (string e in abc)
            {
                Console.WriteLine(e);
            }

            // Работа с функциями и строками
            Console.WriteLine("Hello, world!"); // Вывод "Hello, world!" на экран
            string nimetus = "Python"; // Определение строки nimetus
            Console.WriteLine($"Hello, {nimetus}"); // Вывод приветствия с использованием строки nimetus

            // Вызов статического метода Tere из класса Funktsioonid
            Funktsioonid.Tere(nimetus);

            // Запрос двух чисел от пользователя, выполнение сложения и вывод результата
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus = Funktsioonid.Liitmine(b, a);
            Console.WriteLine(vastus);

            // Преобразование double в int и выполнение сложения
            double arv = 5.123456;
            vastus = Funktsioonid.Liitmine(a, (int)arv);
            Console.WriteLine(vastus);

            // Проверка и вывод символа или результата
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus);
            }

            // Вызов метода Arvuta из класса Funktsioonid
            Console.WriteLine(Funktsioonid.Arvuta("*", 5, 5));

            // Работа с массивом строк
            string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };

            // Различные способы обхода массива строк
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine(nimed[i]);
            }

            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }

            int n = 0;
            while (n < nimed.Length)
            {
                Console.WriteLine(nimed[n]);
                n++;
            }

            do
            {
                n--; // Уменьшение n, чтобы избежать выхода за пределы массива
                Console.WriteLine(nimed[n]);
            } while (n > 0);

            // Пример использования случайных чисел для вывода дней недели
            for (int i = 0; i < 7; i++)
            {
                int paev_nr = random.Next(0, 7);
                string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                Console.WriteLine(paeva_nimetus);
            }

            try
            {
                // Запрос и анализ роста пользователя
                Console.WriteLine("Mis on sinu pikkus?");
                double pikkus = double.Parse(Console.ReadLine());
                string vastus1 = Funktsioonid.Pikkuse_analuus(pikkus);
                Console.WriteLine($"Sinu pikkus on {pikkus}, sa oled {vastus1}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // 1* Задание на создание массива и вывод квадратов чисел
            int N = random.Next(-100, 101); // Генерация случайного числа N
            int M = random.Next(-100, 101); // Генерация случайного числа M

            // Определение начального и конечного значения для заполнения массива
            int start = Math.Min(N, M);
            int end = Math.Max(N, M);

            // Вывод случайных чисел

            N и M
            Console.WriteLine($"Случайные числа: N = {N}, M = {M}");

            // Вычисление количества элементов в массиве
            int size = end - start + 1;
            int[] array = new int[size];

            // Заполнение массива числами от start до end
            for (int i = 0; i < size; i++)
            {
                array[i] = start + i;
            }

            // Вывод квадратов всех чисел массива
            Console.WriteLine("Квадраты чисел от N до M:");
            foreach (int num in array)
            {
                Console.WriteLine($"{num}^2 = {num * num}");
            }
        }
    }

    // Определение класса Auto
    internal class Auto
    {
        public string RegNumber { get; set; } // Свойство для регистрационного номера

        public Color Varv { get; set; } // Свойство для цвета машины

        public Inimene Omanik { get; set; } // Свойство для владельца машины

        // Конструктор по умолчанию
        public Auto() { }

        // Конструктор с параметрами
        public Auto(string regNumber, Color varv, Inimene omanik)
        {
            RegNumber = regNumber; // Инициализация регистрационного номера
            Varv = varv; // Инициализация цвета машины
            Omanik = omanik; // Инициализация владельца машины
        }

        // Метод, который выводит информацию о владельце машины
        public void KelleOmaAuto()
        {
            Console.WriteLine($"{Varv.Name} auto regnumbriga {RegNumber} on {Omanik.Nimi} oma");
        }
    }

    // Определение класса Inimene (необходимо определить его отдельно)
    internal class Inimene
    {
        public string Nimi { get; set; } // Свойство для имени человека
        public int Vanus { get; set; } // Свойство для возраста
        public double Pikkus { get; set; } // Свойство для роста
        public double Kaal { get; set; } // Свойство для веса
        public Sugu Sugu { get; set; } // Свойство для пола

        // Конструктор по умолчанию
        public Inimene() { }

        // Конструктор с параметром имени
        public Inimene(string nimi)
        {
            Nimi = nimi;
        }

        // Конструктор с параметрами имени и возраста
        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
    }

    // Перечисление для пола человека
    internal enum Sugu
    {
        Meessugu, // Мужской пол
        Naissugu // Женский пол
    }

    // Пример класса Funktsioonid (необходимо определить его отдельно)
    internal static class Funktsioonid
    {
        // Пример метода для сложения двух чисел
        public static int Liitmine(int a, int b)
        {
            return a + b;
        }

        // Пример метода для анализа роста
        public static string Pikkuse_analuus(double pikkus)
        {
            return pikkus > 180 ? "pikk" : "lühem";
        }

        // Пример метода для вывода приветствия
        public static void Tere(string nimi)
        {
            Console.WriteLine($"Tere, {nimi}!");
        }

        // Пример метода для получения названия дня недели по номеру
        public static string Paevad(int paev_nr)
        {
            string[] paevad = { "Esmaspäev", "Teisipäev", "Kolmapäev", "Neljapäev", "Reede", "Laupäev", "Pühapäev" };
            return paevad[paev_nr];
        }

        // Пример метода для вычисления операции
        public static double Arvuta(string op, double x, double y)
        {
            switch (op)
            {
                case "+": return x + y;
                case "-": return x - y;
                case "*": return x * y;
                case "/": return x / y;
                default: throw new ArgumentException("Vale operatsioon");
            }
        }

        // Пример метода для создания массива чисел
        public static int[] Arvude_massive(int start, int end)
        {
            int size = Math.Abs(end - start) + 1;
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = start + i;
            }
            return result;
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        List<int> numbers = new List<int>(); // Создаем список из 20 случайных чисел

//        for (int i = 0; i < 20; i++)
//        {
//            numbers.Add(random.Next(1, 101)); // случайные числа от 1 до 100
//        }

//        Console.WriteLine("Исходный список: " + string.Join(", ", numbers));

//        // Сначала выбираем все четные числа
//        List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

//        // Затем выбираем все нечетные числа
//        List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

//        // Объединяем списки: четные + нечетные
//        List<int> sortedNumbers = evenNumbers.Concat(oddNumbers).ToList();

//        Console.WriteLine("Отсортированный список: " + string.Join(", ", sortedNumbers));
//    }
//}


//// ülesane2 
//List<int> list = new List<int>();
//Random random = new Random();
//for (int i = 0; i <= 20; i++)
//{
//    Numbers.Add(random, Next(0, 101));
//}

//List<int> evenNumbers = NumberStyles.Where(n => n % 2 == 0).ToList();

//List<int> oddNumbers = numbers.Where(nameof => n % 1 == 0).ToList();

//List<int> sortNumbers = evenNumbers.Contact(oddNumbers).ToList();

//Console.WriteLine("Sorteeritud numbers: ";
//sortNumbers.ForEach(n => Console.WriteLine(n + " "));


// Ülesanne N3
//using System;
//using System.Collections.Generic;

//class Program2
//{
//    enum Eluviis // Перечисление для выбора уровня активности пользователя
//    {
//        Istuv = 1,    // Сидячий образ жизни
//        Vähene,       // Низкая активность
//        Mõõdukas,     // Умеренная активность
//        Kõrge,        // Высокая активность
//        VägaKõrge     // Очень высокая активность
//    }

//    static void Main()
//    {
//        // Список продуктов и их калорийность
//        List<string> tooted = new List<string> { "Õun", "Banaan", "Kanafilee", "Riis", "Jogurt" };
//        // Калорийность продуктов на 100 грамм
//        List<int> kalorid = new List<int> { 52, 89, 165, 130, 60 };

//        // Запрос пола пользователя
//        Console.Write("Sisesta oma sugu (M/N): ");
//        char sugu = Char.ToUpper(Console.ReadLine()[0]); // Преобразование ввода к верхнему регистру

//        // Запрос веса пользователя
//        Console.Write("Sisesta oma kaal (kg): ");
//        double kaal = double.Parse(Console.ReadLine()); // Преобразование ввода в число типа double

//        // Запрос роста пользователя
//        Console.Write("Sisesta oma pikkus (cm): ");
//        double pikkus = double.Parse(Console.ReadLine()); // Преобразование ввода в число типа double

//        // Запрос возраста пользователя
//        Console.Write("Sisesta oma vanus (aastad): ");
//        int vanus = int.Parse(Console.ReadLine()); // Преобразование ввода в целое число

//        // Расчет основного обмена веществ (SBI) по формуле Харриса-Бенедикта
//        double SBI;
//        if (sugu == 'M') // Если пол мужской
//        {
//            // Формула для мужчин
//            SBI = 66 + (13.7 * kaal) + (5 * pikkus) - (6.8 * vanus);
//        }
//        else // Если пол женский
//        {
//            // Формула для женщин
//            SBI = 655 + (9.6 * kaal) + (1.8 * pikkus) - (4.7 * vanus);
//        }

//        // Вывод значения основного обмена веществ (SBI)
//        Console.WriteLine($"\nSinu põhivajadus (SBI) on {SBI:F2} kalorit.");

//        // Запрос уровня активности пользователя
//        Console.WriteLine("Vali oma aktiivsuse tase:");
//        Console.WriteLine("1. Istuv eluviis");
//        Console.WriteLine("2. Vähene aktiivsus (1-3 korda nädalas)");
//        Console.WriteLine("3. Mõõdukas aktiivsus (3-5 korda nädalas)");
//        Console.WriteLine("4. Kõrge aktiivsus (6-7 korda nädalas)");
//        Console.WriteLine("5. Väga kõrge aktiivsus (treening 2 korda päevas)");
//        int aktiivsuseValik = int.Parse(Console.ReadLine()); // Преобразование ввода в целое число

//        // Расчет коэффициента активности на основе выбранного уровня
//        double aktiivsusKoef = aktiivsuseValik switch
//        {
//            1 => 1.2,    // Сидячий образ жизни
//            2 => 1.375,  // Низкая активность
//            3 => 1.55,   // Умеренная активность
//            4 => 1.725,  // Высокая активность
//            5 => 1.9,    // Очень высокая активность
//            _ => 1.0     // Коэффициент по умолчанию на случай некорректного выбора
//        };

//        // Расчет дневной калорийности на основе основного обмена веществ (SBI) и коэффициента активности
//        double paevaneKaloraaž = SBI * aktiivsusKoef;
//        // Вывод рассчитанной дневной калорийности
//        Console.WriteLine($"\nSinu päevane kaloraaž on umbes {paevaneKaloraaž:F2} kalorit.");

//        // Список для хранения выбранных пользователем продуктов
//        List<string> valitudTooted = new List<string>();

//        // Вывод меню для выбора продуктов
//        Console.WriteLine("\nVali toiduained, mida soovid süüa (sisesta toote number, lõpetamiseks sisesta 0):");
//        for (int i = 0; i < tooted.Count; i++) // Перебор всех продуктов в списке
//        {
//            // Вывод номера продукта и его калорийности на 100 грамм
//            Console.WriteLine($"{i + 1}. {tooted[i]} ({kalorid[i]} kalorit 100g kohta)");
//        }

//        // Цикл для выбора продуктов пользователем
//        while (true)
//        {
//            // Запрос номера продукта у пользователя
//            Console.Write("Sisesta toote number: ");
//            int valik = int.Parse(Console.ReadLine()); // Преобразование ввода в целое число
//            if (valik == 0) break; // Если введен 0, выход из цикла
//            if (valik > 0 && valik <= tooted.Count) // Проверка корректности выбора
//            {
//                valitudTooted.Add(tooted[valik - 1]); // Добавление выбранного продукта в список
//            }
//            else
//            {
//                // Сообщение об ошибке в случае некорректного выбора
//                Console.WriteLine("Vale valik, proovi uuesti.");
//            }
//        }

//        // Вывод данных о выбранных продуктах
//        Console.WriteLine("\nValitud tooted:");
//        int kokkuKalorid = 0; // Переменная для суммирования калорий
//        foreach (var toode in valitudTooted) // Перебор всех выбранных продуктов
//        {
//            int index = tooted.IndexOf(toode); // Получение индекса продукта в списке
//            kokkuKalorid += kalorid[index]; // Суммирование калорий
//            // Вывод названия продукта и его калорийности
//            Console.WriteLine($"{toode} - {kalorid[index]} kalorit 100g kohta");
//        }

//        // Вывод общего количества калорий для всех выбранных продуктов
//        Console.WriteLine($"\nKokku kalorid: {kokkuKalorid} kalorit (arvestatud 100g kohta iga toote puhul).");
//    }
//}

// Ülesann 4
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq; // Импорт необходимых пространств имен

public class County // Определение класса County
{
    public string Capital { get; set; } // Свойство для хранения столицы
    public string Name { get; set; } // Свойство для хранения названия графства

    public County(string capital, string name) // Конструктор класса County
    {
        Capital = capital; // Инициализация свойства Capital
        Name = name; // Инициализация свойства Name
    }
}

public class DictionaryManager // Определение класса DictionaryManager
{
    private Dictionary<string, County> counties; // Словарь для хранения графств

    public DictionaryManager() // Конструктор класса DictionaryManager
    {
        counties = new Dictionary<string, County>(); // Инициализация пустого словаря
    }

    public void AddCounty(string capital, string name) // Метод для добавления графства в словарь
    {
        counties[name] = new County(capital, name); // Добавление графства в словарь
    }

    public string GetCapital(string countyName) // Метод для получения столицы по названию графства
    {
        return counties.ContainsKey(countyName) ? counties[countyName].Capital : null; // Поиск столицы и возврат результата
    }

    public bool AddCapital(string countyName, string newCapital) // Метод для добавления новой столицы графству
    {
        if (!counties.ContainsKey(countyName)) // Проверка наличия графства в словаре
        {
            counties[countyName] = new County(newCapital, countyName); // Добавление нового графства в словарь
            return true; // Успешное добавление
        }
        return false; // Графство уже существует
    }

    public double TestKnowledge(List<string> questions) // Метод для тестирования знаний
    {
        int correctAnswers = 0; // Счетчик правильных ответов
        foreach (var question in questions) // Итерация по вопросам
        {
            if (counties.ContainsKey(question)) // Проверка наличия графства в словаре
            {
                correctAnswers++; // Увеличение счетчика правильных ответов
            }
        }
        return ((double)correctAnswers / questions.Count) * 100; // Возврат процента правильных ответов
    }
}

class Program // Основной класс программы
{
    static void Main() // Главный метод программы
    {
        DictionaryManager manager = new DictionaryManager(); // Создание экземпляра DictionaryManager

        // Добавление нескольких графств в словарь
        manager.AddCounty("Tallinn", "Harjumaa");
        manager.AddCounty("Tartu", "Tartumaa");
        manager.AddCounty("Riga", "Lätimaa");
        manager.AddCounty("Kiev", "Ukraina");

        while (true) // Бесконечная цикл для обработки пользовательских действий
        {
            Console.WriteLine("1. Näita maakonna pealinna"); // Вывод сообщения о выборе действия
            Console.WriteLine("2. Lisada uue maakonna"); // Вывод сообщения о выборе действия
            Console.WriteLine("3. Testida oma teadmisi"); // Вывод сообщения о выборе действия
            Console.WriteLine("4. Lahuta"); // Вывод сообщения о выборе действия
            Console.Write("Valige tegevuse numbri: "); // Запрос ввода номера действия
            int choice = Convert.ToInt32(Console.ReadLine()); // Конвертация введенного числа в целое число

            switch (choice) // Переключатель для выбора действия
            {
                case 1:
                    Console.Write("Sisestage maakonna nimi: "); // Запрос ввода названия графства
                    string countyName = Console.ReadLine(); // Чтение строки с клавиатуры
                    string capital = manager.GetCapital(countyName); // Получение столицы по названию графства
                    if (capital != null) // Проверка наличия столицы
                    {
                        Console.WriteLine($"Maakonna pealinn on {capital}"); // Вывод результатов
                    }
                    else
                    {
                        Console.WriteLine("Sellist maakonda ei leidu sõnastikus."); // Вывод сообщения об ошибке
                    }
                    break;
                case 2:
                    Console.Write("Sisestage uue maakonna pealinn: "); // Запрос ввода новой столицы
                    string newCapital = Console.ReadLine(); // Чтение строки с клавиатуры
                    Console.Write("Sisestage uue maakonna nimi: "); // Запрос ввода названия нового графства
                    string newName = Console.ReadLine(); // Чтение строки с клавиатуры
                    if (!manager.AddCapital(newName, newCapital)) // Проверка успешности добавления
                    {
                        Console.WriteLine("Maakond juba eksisteerib."); // Вывод сообщения об ошибке
                    }
                    else
                    {
                        Console.WriteLine("Maakond on edukalt lisatud."); // Вывод сообщения об успехе
                    }
                    break;
                case 3:
                    Console.WriteLine("Testi algus!"); // Вывод сообщения о начале теста
                    Random random = new Random(); // Создание объекта случайной генерации
                    List<string> testQuestions = new List<string>(); // Создание списка вопросов для теста
                    for (int i = 0; i < 10; i++) // Цикл для генерации 10 вопросов
                    {
                        string question = counties.Values.ToList()[random.Next(counties.Count)].Name; // Выбор случайного графства из словаря
                        testQuestions.Add(question); // Добавление вопроса в список
                    }
                    Console.WriteLine("Vastake järgmiselt:\n"); // Вывод инструкции к тесту
                    foreach (string question in testQuestions) // Цикл для вывода каждого вопроса
                    {
                        Console.Write(question + ": "); // Запрос ответа на вопрос
                        string answer = Console.ReadLine(); // Чтение ответа с клавиатуры
                        if (counties.ContainsKey(answer)) // Проверка наличия ответа в словаре
                        {
                            Console.WriteLine("Õigesti\n"); // Вывод подтверждения правильного ответа
                        }
                        else
                        {
                            Console.WriteLine("Vale\n"); // Вывод сообщения об ошибке
                        }
                    }
                    Console.WriteLine($"Teie teadmised: {manager.TestKnowledge(testQuestions)}%\n"); // Вывод процента правильных ответов
                    break;
                case 4:
                    return; // Завершение выполнения программы
                default:
                    Console.WriteLine("Vale valik."); // Вывод сообщения об ошибке выбора
            }
        }
    }
}
