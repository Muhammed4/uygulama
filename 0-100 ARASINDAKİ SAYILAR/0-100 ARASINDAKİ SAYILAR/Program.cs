using System;

namespace _0_100_ARASINDAKİ_SAYILAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayıyı girin=");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi >= 0 && sayi <= 100)
            {
                Console.WriteLine("sayı 0-100 arasındadır");
            }
            else
            {
                Console.WriteLine("sayı 0-100 arasında değil");
            }
            Console.ReadKey();
        }
    }
}
