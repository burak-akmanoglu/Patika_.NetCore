using System;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


            try
            {
                Console.Write("Lütfen pozitif bir sayı giriniz: ");
                int n;
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                    Console.WriteLine("Girdiğiniz Değer Pozitif Değil !");
                else
                    Console.WriteLine("Dizinin Uzunluğu: " + n);



                int[] dizi = new int[n];
                int sayi;
                Console.WriteLine(n + " Adet Pozitif Değer Giriniz Değer Giriniz:");
                for (int i = 0; i < n; i++)
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Pozitif Değer Giriniz..!");
                    }
                    else if(sayi>=0)
                    {
                        dizi[i] = sayi;
                    }

                }
                int teksayi = 0;
                int ciftsayi = 0;
                foreach (int item in dizi)
                {
                    if (item % 2 == 0)
                    {
                        ciftsayi = ciftsayi + 1;
                        Console.Write(item + " ");
                    }
                    else if (item % 2 == 1)
                    {
                        teksayi = teksayi + 1;
                    }
                }
                if (teksayi != 0 && ciftsayi == 0)
                {
                    Console.WriteLine("Girilen değerlerde çift sayı yoktur!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message.ToString());
            }


        }
    }
}
