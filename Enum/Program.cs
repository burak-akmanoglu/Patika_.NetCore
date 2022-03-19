using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int Sicaklik = 32;

            if (Sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyelim");

            }
            else if (Sicaklik >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarı Çıkmak için çok sıcak bir gün");
            }
            else if (Sicaklik >= (int)HavaDurumu.Normal && Sicaklik < (int)HavaDurumu.Coksıcak)
            {
                Console.WriteLine("Hadi Dışarıya Çıkalım");
            }
        }
    }
    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        pazar,

    }
    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        Coksıcak = 30,
    }
}
