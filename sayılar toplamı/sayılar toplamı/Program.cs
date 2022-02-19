using System;

namespace sayılar_toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            int say1, say2,toplam;
            Console.WriteLine("1.sayı=");
            say1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayı=");
            say2 = Convert.ToInt32(Console.ReadLine());
            toplam = say2 + say1;

            Console.WriteLine("sayıların toplamı=" +toplam);
            Console.ReadKey();


        }
    }
}
