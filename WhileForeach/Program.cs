using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            /* WHİLE */
            // 1'den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a'dan z'ye kadar tüm harfleri console yazdır.
            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.Write(karakter);
                karakter++;
            }

            /* FOREACH */

            Console.WriteLine("****** Foreach ******");
            string[] cars = { "BMW", "FORD", "TOYOTA", "NİSSAN" };
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }


        }
    }
}
