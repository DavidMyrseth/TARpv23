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
            // Создаем генератор случайных чисел
            Random rand = new Random();

            // Генерируем случайные числа N и M в диапазоне от -100 до 100
            int N = rand.Next(-100, 101);
            int M = rand.Next(-100, 101);

            // Определяем начало и конец диапазона
            int start = Math.Min(N, M);
            int end = Math.Max(N, M);

            // Создаем список для хранения чисел из диапазона от N до M
            List<int> arvud = new List<int>();
            for (int i = start; i <= end; i++)
            {
                arvud.Add(i);
            }

            // Выводим квадраты чисел на экран
            Console.WriteLine($"Arvud vahemikus {start} kuni {end}:");
            foreach (int arv in arvud)
            {
                Console.WriteLine($"{arv} ruut on {arv * arv}");
            }
        }
    }

}

