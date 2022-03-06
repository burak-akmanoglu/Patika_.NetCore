using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int sayi;
            ArrayList liste = new ArrayList();
            Console.WriteLine(" 20 Adet Sayı Giriniz: ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. Sayı Giriniz:", i + 1);
                sayi = int.Parse(Console.ReadLine());
                liste.Add(sayi);

            }
            ArrayList kucukliste = new ArrayList();
            ArrayList buyukliste = new ArrayList();


            liste.Sort();

            for (int i = 0; i < 3; i++)
            {
                kucukliste.Add(liste[i]);

            }
            for (int i = liste.Count - 1; i > liste.Count - 4; i--)
            {
                buyukliste.Add(liste[i]);
            }
            Console.WriteLine("******** En Küçük 3 Sayı **********");
            foreach (var item in kucukliste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********* En Büyük 3 Sayı ************");
            foreach (var item in buyukliste)
            {
                Console.WriteLine(item);
            }
            float toplamMin = 0;
            int a = 0;
            float toplamMax = 0;
            int b = 0;
            Console.WriteLine("************** En küçük 3 sayının Toplam ve Ortalaması *****************");
            for (int i = 0; i < kucukliste.Count; i++)
            {
                a = Convert.ToInt32(kucukliste[i]);
                toplamMin = toplamMin + a;
            }


            Console.WriteLine("Toplam:");
            Console.WriteLine(toplamMin);
            Console.WriteLine("Ortalama:");
            Console.WriteLine(toplamMin / kucukliste.Count);

            Console.WriteLine("************** En Büyük 3 sayının Toplam ve Ortalaması *****************");
            for (int i = 0; i < buyukliste.Count; i++)
            {
                b = Convert.ToInt32(buyukliste[i]);
                toplamMax = toplamMax + b;
            }


            Console.WriteLine("Toplam:");
            Console.WriteLine(toplamMax);
            Console.WriteLine("Ortalama:");
            Console.WriteLine(toplamMax / buyukliste.Count);


            Console.WriteLine("************** Ortalamanın Toplamları*****************");
            Console.WriteLine((toplamMax / buyukliste.Count) + (toplamMin / kucukliste.Count));

        }

    }
}
