using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace TARpv23_CSharp 
    internal class Funktsioonid 
    {
        public static void Tere(string nimi) // Метод, который выводит приветствие с именем
        {
            Console.WriteLine("Tere kallis {0}", nimi); // Выводит приветственное сообщение, используя имя пользователя
        }

        public static int Liitmine(int arv1, int arv2) // Статический метод, который складывает два целых числа и возвращает результат
        {
            return arv1 + arv2; // Возвращает сумму двух чисел
        }

        public static double Arvuta(string operatsion, int arv1, int arv2) // Статический метод для выполнения арифметических операций
        {
            double Arve = 0; // Инициализация переменной для хранения результата операции
            if (operatsion == "+") // Проверка, является ли операция сложением
            {
                Arve = arv1 + arv2; // Выполняется сложение
            }
            else if (operatsion == "-") // Проверка, является ли операция вычитанием
            {
                Arve = arv1 - arv2; // Выполняется вычитание
            }
            else if (operatsion == "/") // Проверка, является ли операция делением
            {
                Arve = (double)arv1 / arv2; // Выполняется деление, приведение к типу double для правильного деления
            }
            else if (operatsion == "*") // Проверка, является ли операция умножением
            {
                Arve = arv1 * arv2; // Выполняется умножение
            }
            return Arve; // Возвращает результат операции
        }

        // Метод для получения названия дня недели по его номеру
        public static string Paevad(int nr) 
        {
            string paev; // Переменная для хранения названия дня
            switch (nr) // Выбор дня недели в зависимости от номера
            {
                case 1: paev = "Esmaspäev"; break; // Если 1, то день - понедельник
                case 2: paev = "Teisipäev"; break; // Если 2, то день - вторник
                case 3: paev = "Kolmapäev"; break; // Если 3, то день - среда
                case 4: paev = "Neljapäev"; break; // Если 4, то день - четверг
                case 5: paev = "Reede"; break; // Если 5, то день - пятница
                case 6: paev = "Laupäev"; break; // Если 6, то день - суббота (исправлено на правильное название)
                case 7: paev = "Pühapäev"; break; // Если 7, то день - воскресенье
                default: // Если номер не соответствует ни одному из дней
                    paev = "Ei saa määrata"; // Сообщение об ошибке
                    break;
            }
            return paev; // Возвращает название дня недели
        }

        // Метод для анализа роста человека
        public static string Pikkuse_analuus(double pikkus) 
        {
            string analuus; // Переменная для хранения результата анализа
            if (pikkus < 1.6) // Если рост меньше 1.6 метра
            {
                analuus = "Lühike kasvu inimene"; // Возвращаем результат, что человек невысокого роста
            }
            else if (pikkus < 1.8) // Если рост меньше 1.8 метра, но больше или равно 1.6 метра
            {
                analuus = "Keskmine kasvu inimene"; // Возвращаем результат, что человек среднего роста
            }
            else // Если рост 1.8 метра или больше
            {
                analuus = "Pikka kasvu inimene"; // Возвращаем результат, что человек высокого роста
            }
            return analuus; // Возвращаем результат анализа
        }

        // Метод для создания массива чисел от N до M
        public static int[] Arvude_massive(int N, int M) 
        {
            int[] arvud = new int[M - N + 1]; // Создаем массив размером от M до N (исправлено на корректный размер массива)
            for (int i = 0; i < arvud.Length; i++) // Цикл по всему массиву
            {
                arvud[i] = N; // Заполняем массив значениями, начиная с N
                N++; // Увеличиваем значение N на 1
            }
            return arvud; // Возвращаем массив чисел
        }
    }
}
