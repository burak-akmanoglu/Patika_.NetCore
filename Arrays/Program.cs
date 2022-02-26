using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dizi Tanımlama*/
            string[] renkler = new string[5];
            string[] hayvanlar = { "Cat", "Dog", "Bird", "Monkey" };

            int[] dizi;
            dizi = new int[5];

            /* Dizilere Değer Atama ve Erişim */
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            /* Döngülerle Dizi Kullanımı */

            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz: ");
            int diziuzunlugu=int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziuzunlugu];

            for (int i = 0; i <diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz :",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());

            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam +=sayi;
            }
            Console.WriteLine("Ortalama : "+toplam/diziuzunlugu);

        }
    }
}
