using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;

                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız");
                    break;

                default:
                    Console.WriteLine("Yanlış Veri Girdiniz!");
                    break;
            }
            switch (month)
            {
                //Çoklu case kullanımı
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındasınız");
                    break;


                default:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
