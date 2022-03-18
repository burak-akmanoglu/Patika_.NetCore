using System;
namespace classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "BURAK";
            calisan1.soyad = "AKMAN";
            calisan1.no = 373737;
            calisan1.departman = "IT DEPARTMAN";

            calisan1.CalisanBilgi();
            Console.WriteLine("***********************");
             Calisan calisan2 = new Calisan();
            calisan1.ad = "ALİ";
            calisan1.soyad = "KUZEY";
            calisan1.no = 7857954;
            calisan1.departman = "İK";

            calisan1.CalisanBilgi();
        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public void CalisanBilgi()
        {
            Console.WriteLine("Worker name: " + ad);
            Console.WriteLine("Worker surname: " + soyad);
            Console.WriteLine("Worker no: " + no);
            Console.WriteLine("Worker department: " + departman);
        }

    }
}