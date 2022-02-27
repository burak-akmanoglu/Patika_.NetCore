using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* erisim_belirteci geri_donus_tipi metot_adı(parametreListesi/Argüman)
             { 
                 komutlar;
                 return;

             }  */

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            Console.WriteLine("***** Method Toplama *****");
            int sonuc = topla(a, b);
            Console.WriteLine(sonuc);
            Console.WriteLine(topla(a, b));

            Methodlar ornek = new Methodlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            // int sonuc2 = ornek.ArttırVeTopla(a, b);
            // ornek.EkranaYazdır(Convert.ToString(sonuc2));
            // ornek.EkranaYazdır(Convert.ToString(a+b));

            ornek.EkranaYazdır("******** Referanslar *********");

            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a + b));



        }
        static int topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }


    }
    class Methodlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttırVeTopla(ref int deger1, ref int deger2) //ref ile referanslarını bellekteki adreslerini belirttik
        {
            deger1 += 1;
            deger2 += 1;

            return (deger1 + deger2);
        }
    }
}
