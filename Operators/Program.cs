using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Atama ve İşlemli Atama*/

            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            /*Mantıksal Operatörler || && !  */
Console.WriteLine("************* Mantıksal Operatörler **************");
            bool isSuccess = true;
            bool isComplated = false;

            if (isSuccess && isComplated)
                Console.WriteLine("Perfect!");

            if (isSuccess || isComplated)
                Console.WriteLine("Great!");

            if (isSuccess && !isComplated)
                Console.WriteLine("Fine!");

            /*İlişkisel Operatörler < > <= >= == !=   */
Console.WriteLine("************* İlişkisel Operatörler **************");
            int a = 3;
            int b = 3;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            /*Aritmatik Operatörler / * + - */
            Console.WriteLine("************* Aritmatik Operatörler **************");

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);



        }
    }
}
