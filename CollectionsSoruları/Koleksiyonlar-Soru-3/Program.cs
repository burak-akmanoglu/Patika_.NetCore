using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.   
        Console.WriteLine("Lütfen bir cümle giriniz");
        char[] sesli={'a','e','o','i','u','ü','ö','ı','A','E','O','İ','U','Ü','Ö','I'};
        string cumle = Console.ReadLine();
        Console.WriteLine("********************************");
        List<char> seslicumle=new List<char>();

        foreach (var item in cumle)
        {
            foreach (var chardizi in sesli)
            {
             if (chardizi==item)
             {
                 seslicumle.Add(item);  
             }   
            }
        }
        foreach (var item in seslicumle)
        {
            Console.WriteLine(item);
        
        }}
    }
}
