using System;

namespace Uppgift2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge har du tänkte hyra den här bilen?");
            string strDagar = Console.ReadLine();
            int Dagar = int.Parse(strDagar);


            Console.WriteLine("Hur långt har du tänkt köra? Svara i Km");
            string strLängd = Console.ReadLine();
            int Km = int.Parse(strLängd);

            int total = 300 + 500 * (Dagar - 1) + (1 * Km);
            Console.WriteLine("Din totala kostnad är" + total);

        }
    }
}