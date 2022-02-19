using System;

namespace AD_SOYAD_EKRANA_YAZDIRMA
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim, soyisim;

            Console.WriteLine("isminizi girin:");
            isim = Console.ReadLine();
            Console.WriteLine("Soyisiminizi girin:");
            soyisim = Console.ReadLine();

            Console.WriteLine("Merhaba {0} {1}", isim, soyisim);

            Console.ReadKey();
        }
    }
}
