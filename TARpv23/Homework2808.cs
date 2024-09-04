using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23
{
    internal class Homework2808;

class Program
    {
        static void Main()
        {
            Random rand = new Random();  // Генератор случайных чисел


            int N = rand.Next(-100, 101);// Генерируем числа N и M в диапазоне от -100 до 100
            int M = rand.Next(-100, 101);

            int start = Math.Min(N, M); // Вычисляем манимальное значение из N,M ->START
            int end = Math.Max(N, M); // Вычисляем максимальное значение из N,M ->END

            List<int> arvud = new List<int>(); // Cписок для хранения из чисел в диапазона от N до M
            for (int i = start; i <= end; i++)
            {
                arvud.Add(i);
            }

            Console.WriteLine($"Arvud vahemikus {start} kuni {end}:"); // Выводим квадраты чисел на экран
            foreach (int arv in arvud)
            {
                Console.WriteLine($"{arv} ruut on {arv * arv}");
            }
        }
    }

}

