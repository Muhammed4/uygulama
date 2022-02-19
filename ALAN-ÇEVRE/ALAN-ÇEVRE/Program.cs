using System;

namespace ALAN_ÇEVRE
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisakenar, uzunkenar, alan, cevre;
            Console.Write("Kısa Kenarı giriniz=");
            kisakenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenar giriniz=");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            alan = kisakenar * uzunkenar;
            cevre = 2 * (kisakenar + uzunkenar);
            Console.WriteLine("Alan=" + alan);
            Console.WriteLine("Çevre=" + cevre);
            Console.ReadKey();
        }
    }
}
