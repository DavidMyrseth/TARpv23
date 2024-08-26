using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //I. osa Anmdettüübid, ALamfunktsioonid
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello {0}", nimetus);
            Funksioonid.Tere(nimetus);
            Console.Write("Sisesta esimine arv: ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus=Funksioonid.Liitmine(a,b);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus=Funksioonid.Liitmine(a,(int)arv);
            Console.WriteLine(vastus);
            char taht = 'A'; // Simvoli v odinarniih kovitskah
            if (vastus == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus);
            }
        }
    }
}

