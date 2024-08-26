using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23
{
    public class Kodutoo
    {

class Program
    {
        public static void Main()
        {
            // 1 inimese nime
            Console.Write("Sisesta esimese inimese nimi: ");
            string nimi1 = Console.ReadLine();
            // 2 inimese nime
            Console.Write("Sisesta teise inimese nimi: ");
            string nimi2 = Console.ReadLine();
            // pinginaabrid
            Console.WriteLine($"{nimi1} ja {nimi2} pinginaabrid.");
        }
    }
}
}
