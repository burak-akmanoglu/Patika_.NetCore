using System;

namespace Soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir cümle yazın lütfen");
            string ifade = Console.ReadLine();

            string[] kelime = ifade.Split(" ");
            int sayi = 0;
            for (int i = 0; i < kelime.Length; i++)
            {
                char[] harf = kelime[i].ToCharArray();
                sayi += harf.Length;
            }
            Console.WriteLine(kelime.Length + " adet kelime");
            Console.WriteLine(sayi+" adet harf");
        }
    }
}
