using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringdegisken = " ";
            if (stringdegisken == " ")
            {
                Console.WriteLine("stringdegisken boşluk karakterine sahiptir.");
            }

            byte b = 5;  //1 byte yer kaplar
            sbyte a = 5; //1 byte yer kaplar

            short s = 5;  //2 byte yer kaplar
            ushort us = 5; //2 byte yer kaplar

            Int16 i16 = 2;  //2 byte yer kaplar
            int i = 2;      //4 byte yer kaplar
            Int32 i32 = 2;  //4 byte yer kaplar
            Int64 i64 = 2;  //8 byte yer kaplar

            uint ui = 2;  //4 byte yer kaplar
            long l = 4;   //8 byte yer kaplar
            ulong ul = 4; //8 byte yer kaplar


            /*REEL SAYILAR*/

            float f = 5;  //4 
            double d = 5; //8
            decimal de = 5; //16

            char ch = '2'; //2
            string str = "Burak"; //Sınırsız

            bool b1 = true;
            bool b2 = false;

            /*DateTime*/

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            /*Objects*/

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            /*String İfadeler*/

            string str1 = string.Empty;
            str1 = "Burak Akmanoglu";
            string ad = "Burak";
            string soyad = "AKmanoglu";
            string tamIsim = ad + " " + soyad;

            /*Integer İfadeler*/

            int Integer1 = 5;
            int Integer2 = 3;
            int Integer3 = Integer1 * Integer2;

            /*Boolean*/

            bool bool1 = 10 > 2;

            /*Değişken Dönüşümleri*/

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //Output 2020

            int int21 = int20 + Convert.ToInt32(str1);
            Console.WriteLine(int21);  //Output 40

            int int22 = int20 + int.Parse(str20); //Output 40

            /*DateTime 2*/

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);



        }
    }
}
