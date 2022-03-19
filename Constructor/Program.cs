using System;

namespace Constructor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*************** Çalışan 1  ********************");
            Calisan calisan1 = new Calisan("Burak", "Akman", 373737, "IT Departman");
            calisan1.calisanbilgiler();

            Console.WriteLine("*************** Çalışan 2  ********************");
            Calisan calisan2 = new Calisan();
            calisan2.ad = "Ali";
            calisan2.soyad = "Kuzey";
            calisan2.no = 46894;
            calisan2.departman = "İK";
            calisan2.calisanbilgiler();

            Console.WriteLine("*************** Çalışan 3  ********************");
            Calisan calisan3 = new Calisan("Ramiz", "Kara");
            calisan3.calisanbilgiler();
        }
    }
    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;

        public string departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
            this.departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;

        }
        public Calisan()
        {

        }

        public void calisanbilgiler()
        {
            Console.WriteLine("Worker name: " + ad);
            Console.WriteLine("Worker surname: " + soyad);
            Console.WriteLine("Worker no: " + no);
            Console.WriteLine("Worker department: " + departman);
        }

    }
}