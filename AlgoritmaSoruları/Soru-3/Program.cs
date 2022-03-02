using System;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            int n =int.Parse(Console.ReadLine());
            Console.WriteLine(n);   
            string[] dizi =new string[n];
            for (int i = 0; i < n; i++)
            {
                dizi[i]=Console.ReadLine();
                
            }
            Console.WriteLine("****** Sondan Başa **********");
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
