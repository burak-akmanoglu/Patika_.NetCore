using System;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            try
            {
                int n, m;
                Console.WriteLine("N sayısı:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("M sayısı:");
                m = int.Parse(Console.ReadLine());

                if (m > 0)
                {
                    int sayi;
                    int[] dizi = new int[n];
                    Console.WriteLine(n + " adet sayı giriniz:");
                    for (int i = 0; i < n; i++)
                    {
                        sayi = int.Parse(Console.ReadLine());
                        dizi[i] = sayi;

                    }
                    Console.WriteLine("M'e tam bölünenler");
                    foreach (int item in dizi)
                    {
                        if (item % m == 0 || item == m)
                            Console.WriteLine(item);
                    }
                }
                else{Console.WriteLine("M sayısını Pozitif değer girin");}
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message.ToString());
            }

        }
    }
}
