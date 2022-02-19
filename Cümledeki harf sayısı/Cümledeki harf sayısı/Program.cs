using System;

namespace Cümledeki_harf_sayısı
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            Console.WriteLine("cümle giriniz:");
            s = Console.ReadLine();
            int count = 0;
            foreach (char c in s)
            {
                count++;
                Console.WriteLine(count);
            }

        }
    }
}
