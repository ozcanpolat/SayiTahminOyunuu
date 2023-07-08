using System;

namespace SayiTahminOyunu
{
    internal class Program
    {
        static Random rastgele = new Random();

        static void Main(string[] args)
        {
            int tahmin, sayi = rastgele.Next(100);
            int hak = 5;

            while (true)
            {
                Console.WriteLine("\n\n" + hak-- + " hakkınız var.");
                if (hak < 0)
                {
                    Console.WriteLine("KAYBETTİNİZ!");
                    break;
                }

                Console.Write("SAYI GİRİNİZ: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > sayi)
                {
                    Console.WriteLine("Daha KÜÇÜK bir sayı giriniz.");
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Daha BÜYÜK bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine("TEBRİKLER!");
                }
            }

        }
    }
}
