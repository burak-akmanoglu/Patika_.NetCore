using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Burak", "Akmanoglu", "IT");
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Halil", "ibrahim", "IT");
            Calisan calisan2 = new Calisan("Ali", "Veli", "IT");
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);


            Console.WriteLine("Toplama işlemi Sonucu :{0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işleme sonucu:{0}",Islemler.Cikar(400,50));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Departman = departman;
            this.Soyisim = soyisim;
            calisanSayisi++;
        }

    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
