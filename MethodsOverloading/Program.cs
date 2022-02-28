using System;

namespace MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outsayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outsayi);

            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Methodlar instance = new Methodlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            /*Method Aşırı Yükleme - Overloading */

            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("Burak " , "Akmanoğlu");

            // Method İmzası
            //MethodAdı + Parametre sayısı + Parametre


        }
        class Methodlar
        {
            public void Topla(int a, int b, out int Toplam)
            {
                Toplam = a + b;

            }
            public void EkranaYazdır(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdır(int veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdır(string veri1, string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }

        }
    }
}
