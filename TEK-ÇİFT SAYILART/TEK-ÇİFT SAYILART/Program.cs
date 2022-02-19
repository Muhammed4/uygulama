using System;

namespace TEK_ÇİFT_SAYILART
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("SAYI GİRİNİZ = ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Çift");
            }

            else
            {
                Console.WriteLine("Tek");
            }
        }
    }
}
