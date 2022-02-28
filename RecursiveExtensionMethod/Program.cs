using System;

namespace RecursiveExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            // Rekürsif - Öz yinelemeli
            // 3^4 =3*3*3*3;

            int result = 1;

            for (int i = 1; i < 5; i++)
                result = result * 3;

            Console.WriteLine(result);

            Islemler instance = new(); //
            Console.WriteLine(instance.Expo(3, 4));

            /* Extension Methodlar */
            string ifade = "Burak Akman Oğlu";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());

            //ToUpper
            Console.WriteLine(ifade.MakeUpperCase());
            string sonucum = ifade.ToUpper();
            Console.WriteLine(sonucum);

            //ToLower
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYaz();

            //IsEvenNumber
            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            //Get String Character
            Console.WriteLine(ifade.GetStringCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;

            return Expo(sayi, us - 1) * sayi;
        }
        // Expo(3,4)
        //Expo(3,3) * 3 ;
        // Expo(3,2) * 3 * 3;
        //Expo(3,1) * 3 * 3 *3;
        // 3* 3*3*3= 3^4;
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param) //this ifadesi ile extension oluyor.
        {
            return param.Contains(" "); //Contains String fonksiyonudur. Boşluk var ise true dönecektir
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" "); //String ifadesini boşluklara bölerek dizi oluşturmaktadır.
            return string.Join("*", dizi);//Join methodu string ifaddeyi birleştirmeyi sağlar.

        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;

        }
        public static void EkranaYaz(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetStringCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }

}
