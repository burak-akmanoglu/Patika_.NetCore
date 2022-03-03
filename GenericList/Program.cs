using System;
using System.Collections.Generic;
namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class 
            //System.Collections.Generic
            // T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve list.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            sayiListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde Arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");

            //Eleman ile Index'e Erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl Temizleriz
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullanıcıListesi = new List<Kullanicilar>();

            Kullanicilar kullanıcı1 = new Kullanicilar();
            kullanıcı1.Isim1 = "Ayşe";
            kullanıcı1.Soyisim1 = "yIlaz";
            kullanıcı1.Yas1 = 26;

            Kullanicilar kullanıcı2 = new Kullanicilar();
            kullanıcı2.Isim1 = "Özcan";
            kullanıcı2.Soyisim1 = "Çalışkan";
            kullanıcı2.Yas1 = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);
            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar(){
                Isim1="Deniz",
                Soyisim1="Arda",
                Yas1=24,
            });

            foreach (var kullanici in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim1);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim1);
                Console.WriteLine("Kullanıcı Yas: " + kullanici.Yas1);
            }
            hayvanListesi.Clear();

        }
    }
   
    public class Kullanicilar{
        private string Isim;
        private string Soyisim;

        private int Yas;

        public string Isim1 { get => Isim; set => Isim = value; }
        public string Soyisim1 { get => Soyisim; set => Soyisim = value; }
        public int Yas1 { get => Yas; set => Yas = value; }
    }
}
