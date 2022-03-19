using System;

namespace encapsulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Burak";
            ogrenci.Soyisim = "AKmanoglu";
            ogrenci.Ogrencino = 293;
            ogrenci.Sinif = 3;

            ogrenci.ogrenciBilgi();

            ogrenci.SinifAtlat();
            ogrenci.ogrenciBilgi();

            Ogrenci ogrenci1 = new Ogrenci("Süleyman", "Çakır", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.ogrenciBilgi();


        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrencino;
        private int sinif;

        public Ogrenci()
        {
        }
        public Ogrenci(string isim, string soyisim, int ogrencino, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            Ogrencino = ogrencino;
            Sinif = sinif;
        }
        public void ogrenciBilgi()
        {
            Console.WriteLine("******* Öğrenci Bilgileri ********");
            Console.WriteLine("İsim: " + this.Isim);
            Console.WriteLine("Soyisim: " + this.Soyisim);
            Console.WriteLine("Öğrenci No: " + this.Ogrencino);
            Console.WriteLine("Sınıf: " + this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Soyisim
        {
            get => soyisim;
            set => soyisim = value;
        }
        public int Ogrencino
        {
            get => ogrencino;
            set => ogrencino = value;
        }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value == -1)
                {
                    Console.WriteLine("Sınıf En az 1 olabilir");
                    sinif = 1;
                }

                else
                {
                    sinif = value;
                }



            }
        }
    }
}