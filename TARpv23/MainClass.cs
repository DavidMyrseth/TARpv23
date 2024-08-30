using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpv23;

namespace TARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            
            Console.OutputEncoding = Encoding.UTF8;
            //III. osa OOP
            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 130;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            Inimene inimene3 = new Inimene("David", 18);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina", 18));
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on "+ inimene.Vanus + "aastat vana");
            }
            //II. OSA listf ja sõnastikud
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimine");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            Console.WriteLine("Otsing: ");
            string vas=Console.ReadLine();
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


            //I.osa Andmetüübid, Alamfunktsioonid, IF
            string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
            //1.V
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine(nimed[i]);
            }
            //2.v
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            //3.v
            int n = 0;
            while (n < nimed.Length)
            {
                Console.WriteLine(nimed[n]);
                n++;
            }
            //4.v
            do
            {
                Console.WriteLine(nimed[n - 1]);
                n--;
            } while (n! > 0); //!







            for (int i = 0; i < 7; i++)
            {
                int paev_nr = random.Next(-4, 30);
                string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                Console.WriteLine(paeva_nimetus);
            }



            try
            {




                Console.WriteLine("Mis on sinu pikkus?");
                double pikkus = Double.Parse(Console.ReadLine());
                string vastus1 = Funktsioonid.Pikkuse_analuus(pikkus);
                Console.WriteLine("Sinu pikkus on {0}, sa oled {1}", pikkus, vastus1);
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }



            ////1* Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus (-100,100).
            int N = random.Next(-100, 101);
            int M = random.Next(-100, 101);
            int[] arvud;

            if (N < M)
            {
                arvud = Funktsioonid.Arvude_massive(N, M);
            }
            else
            {
                arvud = Funktsioonid.Arvude_massive(N, M);
            }
            foreach (int item in arvud)
            {
                Console.WriteLine(item * item);
            }

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

        }

    }
}