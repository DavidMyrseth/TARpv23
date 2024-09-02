using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpv23;

namespace TARpv23_CSharp
{
    public class MainClass2
        Internet class Inimine


        public int

        public interface Vanus { get; set; }

        public int 
        public static void Main(string[] args)
        {
            Random random = new Random();

            Console.OutputEncoding = Encoding.UTF8;
            //III. osa OOP
            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 352;
            inimene1.Pikkus = 200;
            inimene1.Kaal = 100;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            inimene2.Sugu = Sugu.naine;
            inimene2.Pikkus = 200;
            inimene2.Kaal = 100;
            Inimene inimene3 = new Inimene("David", 18);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina", 18));
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus + "aastat vana");
            }

            Auto auto1 = new Auto("681MRP", Color.Bisque, inimene1);
            Auto auto2 = new Auto("180ABC", Color.NavajoWhite, inimene2);
            Auto auto3 = new Auto("079TDI", Color.Red, inimene3);
            auto1.KelleOmaAuto();
            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();
            register.Add(auto1, inimene1);
            register.Add(auto2, inimene2);
            register.Add(auto3, inimene3);
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key.RegNumber} - {item.Value.Nimi}");
            }
            foreach (KeyValuePair<Auto, Inimene> pair in register)
            {
                Console.WriteLine(pair.Key.RegNumber + "-" + pair.Value.Nimi);
            }


            //II. OSA listf ja sõnastikud
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimine");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            Console.WriteLine("Otsing: ");
            string vas = Console.ReadLine();
            if (vas != null && arrayList.Contains(vas))
            {
                Console.WriteLine("Otsitav element asub " + arrayList.IndexOf(vas) + ".kohal");
            }
            else
            {
                Console.WriteLine("Kokku oli " + arrayList.Count + "elemente, vaid otsitav puudub ")
            }
            arrayList.Clear();
            arrayList.Insert(1, "Anna");
            arrayList.Insert(0, "Inna");
            // I. --
            List<string> abc = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\ABC.txt"))
                {
                    abc.Add(rida);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Fail ei saa leida!");
            }
            foreach (string e in abc)
            {
                Console.Write(e);
            }
            Console.ReadLine();
            //
            Console.WriteLine("Hello, world!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}", nimetus);
            Funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus = Funktsioonid.Liitmine(b, a);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus = Funktsioonid.Liitmine(a, (int)arv);
            Console.WriteLine(vastus);
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus);
            }
            Console.WriteLine(Funktsioonid.Arvuta("*", 5, 5));
        }


        ////I.osa Andmetüübid, Alamfunktsioonid, IF
        //string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
        ////1.V
        //for (int i = 0; i < nimed.Length; i++)
        //{
        //    Console.WriteLine(nimed[i]);
        //}
        ////2.v
        //foreach (string nimi in nimed)
        //{
        //    Console.WriteLine(nimi);
        //}
        ////3.v
        //int n = 0;
        //while (n < nimed.Length)
        //{
        //    Console.WriteLine(nimed[n]);
        //    n++;
        //}
        ////4.v
        //do
        //{
        //    Console.WriteLine(nimed[n - 1]);
        //    n--;
        //} while (n! > 0); //!

        //for (int i = 0; i < 7; i++)
        //{
        //    int paev_nr = random.Next(-4, 30);
        //    string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
        //    Console.WriteLine(paeva_nimetus);
        //}
        //try
        //{

        //    Console.WriteLine("Mis on sinu pikkus?");
        //    double pikkus = Double.Parse(Console.ReadLine());
        //    string vastus1 = Funktsioonid.Pikkuse_analuus(pikkus);
        //    Console.WriteLine("Sinu pikkus on {0}, sa oled {1}", pikkus, vastus1);
        //}
        //catch (Exception e)
        //{
        //    Console.Write(e.ToString());
        //}

        //////1* Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus (-100,100).
        //int N = random.Next(-100, 101);
        //int M = random.Next(-100, 101);
        //int[] arvud;

        //if (N < M)
        //{
        //    arvud = Funktsioonid.Arvude_massive(N, M);
        //}
        //else
        //{
        //    arvud = Funktsioonid.Arvude_massive(N, M);
        //}
        //foreach (int item in arvud)
        //{
        //    Console.WriteLine(item * item);
        //}

        //int N = random.Next(-100, 101);
        //int M = random.Next(-100, 101);

        //// Определение начального и конечного значения для заполнения массива
        //int start = Math.Min(N, M);
        //int end = Math.Max(N, M);

        //// Вывод случайных чисел N и M
        //Console.WriteLine($"Случайные числа: N = {N}, M = {M}");

        //// Вычисление количества элементов в массиве
        //int size = end - start + 1;
        //int[] array = new int[size];

        //// Заполнение массива числами от start до end
        //for (int i = 0; i < size; i++)
        //{
        //    array[i] = start + i;
        //}

        //// Вывод квадратов всех чисел массива
        //Console.WriteLine("Квадраты чисел от N до M:");
        //foreach (int num in array)
        //{
        //    Console.WriteLine($"{num}^2 = {num * num}");
        //}

        internal class Auto
        {
            public string RegNumber { get; set; }

            public Color Varv { get; set; }

            public Inimene Omanik { get; set; }

            public Auto() { }

            public Auto(string regNumber, Color varv, Inimene omanik)
            {
                regNumber = regNumber;
                Varv = varv;
                Omanik = omanik;
            }

            public void KelleOmaAuto()
            {
                Console.WriteLine($"{Varv.Name} auto regnumbriga {Regnumbur} on {Omanik.Nimi} oma");
            }
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
//for (int i = 0; i <= 20; i++) {
//    Numbers.Add(random, Next(0, 101));
//}

//List<int> evenNumbers = NumberStyles.Where(n => n % 2 ==0).ToList();

//List<int>oddNumbers = numbers.Where(nameof => n % 1 == 0).ToList();

//List<int> sortNumbers = evenNumbers.Contact(oddNumbers).ToList();

//Console.WriteLine("Sorteeritud numbers: ";
//sortNumbers.ForEach(n => Console.WriteLine(n + " "));

// Ülesanne N3
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Создаем списки продуктов и их калорийности (калорийность указана в ккал на 100 г)
//        List<string> products = new List<string>
//        {
//            "Apple", "Banana", "Chicken Breast", "Rice", "Broccoli"
//        };

//        List<int> calories = new List<int>
//        {
//            52, 89, 165, 130, 55 // Соответственно калорийность продуктов на 100 г
//        };

//        // Запрашиваем у пользователя данные для расчета калорийности
//        Console.Write("Введите ваш вес (в кг): ");
//        double weight = double.Parse(Console.ReadLine());

//        Console.Write("Введите ваш рост (в см): ");
//        double height = double.Parse(Console.ReadLine());

//        Console.Write("Введите ваш возраст: ");
//        int age = int.Parse(Console.ReadLine());

//        Console.Write("Введите ваш уровень активности (1 - низкий, 2 - умеренный, 3 - высокий): ");
//        int activityLevel = int.Parse(Console.ReadLine());

//        // Рассчитываем базальный уровень метаболизма (BMR) по формуле Харриса-Бенедикта для мужчин
//        double bmr = 88.36 + (13.4 * weight) + (4.8 * height) - (5.7 * age);

//        // Множитель активности
//        double activityMultiplier = 1.2; // Низкий

//        if (activityLevel == 2)
//        {
//            activityMultiplier = 1.55; // средний
//        }
//        else if (activityLevel == 3)
//        {
//            activityMultiplier = 1.725; // Высокий
//        }

//        // Рассчитываем дневную норму калорий
//        double dailyCalories = bmr * activityMultiplier;

//        Console.WriteLine($"Ваша дневная норма калорий: {dailyCalories:F2} ккал");

//        // Рассчитываем, сколько граммов каждого продукта пользователь может съесть в день
//        Console.WriteLine("Вы можете потреблять следующие количества продуктов в день:");

//        for (int i = 0; i < products.Count; i++)
//        {
//            double grams = (dailyCalories / calories[i]) * 100;
//            Console.WriteLine($"{products[i]}: {grams:F2} г");
//        }
//    }
//}

//public static void Ul1()
//{
//    Console.OutputEncording = Encording.UTF8;
//    Console.WriteLine("Sisesta numbrid");
//    string numbstr = Console.ReadLine();
//    string[] numblist = numbstr.Split(" ");
//    int[] newlist = new int[numblist.Length];

//    for (int i = 0; i < numblist.Length; i++)
//    {
//        int a;
//        if (i == 0)
//        {
//            a = int.Parse(numblist[numblist.Length - 1]) + int.Parse(numblist[0]);
//        }
//        else
//        {
//            a = int.Parse(numblist[numblist.Length - 1]) + int.Parse(numblist[1]);
//        }

//        newlist[i] = a;
//    }

//    Console.WriteLine("New list of sums");
//    Console.WriteLine(string.Join(" ", newlist));
//}

public double HB_vorrand()
{
    double SBI = 0;
    if (Sugu == 0)
    {
        SBI = 66 + (13.7 * kaal) + (5 + Pikkus) - (6.8);
    }
}
