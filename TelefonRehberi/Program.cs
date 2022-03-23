using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

            List<Rehber> kisiler = new List<Rehber>();
            kisiler.Add(new Rehber("Burak", "Akmanoglu", 045485489));
            kisiler.Add(new Rehber("Ali", "Yazar", 045485487));
            kisiler.Add(new Rehber("Veli", "Bozar", 045485485));
            kisiler.Add(new Rehber("Kuzey", "tekin", 045485483));
            kisiler.Add(new Rehber("Ramiz", "Kara", 045485482));




            int sayi = int.Parse(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Ekleme();
                    break;
                case 2:
                    Silme();
                    break;
                case 3:
                    Guncelle();
                    break;
                case 4:
                    Listeleme();
                    break;
                case 5:
                    Arama();
                    break;
            }
            void Ekleme()
            {
                Console.WriteLine("Lütfen isim giriniz             :"); string isim = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz          :"); string soyisim = Console.ReadLine();
                Console.WriteLine("Lütfen telefon numarası giriniz :"); long numara = int.Parse(Console.ReadLine());
                kisiler.Add(new Rehber(isim, soyisim, numara));
                Listeleme();

            }
            void Listeleme()
            {
                for (int i = 0; i < kisiler.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". kişi :  " + kisiler[i].ad + " " + kisiler[i].soyad + " " + kisiler[i].number);
                }
            }
            void Arama()
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("**********************************************");
                Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                int sec = int.Parse(Console.ReadLine());

                if (sec == 1)
                {
                    string adlar = Console.ReadLine();


                    for (int i = 0; i < kisiler.Count; i++)
                    {
                        if (adlar == kisiler[i].ad || adlar == kisiler[i].soyad)
                        {
                            Console.WriteLine(" Arama Sonuçlarınız:");

                            Console.WriteLine("**********************************************");

                            Console.WriteLine(" isim: {0}", kisiler[i].ad);
                            Console.WriteLine(" Soyisim: {0}", kisiler[i].soyad);
                            Console.WriteLine("  Telefon Numarası: {0}", kisiler[i].number);

                        }
                    }
                }
                if (sec == 2)
                {
                    long numara = int.Parse(Console.ReadLine());
                    for (int i = 0; i < kisiler.Count; i++)
                    {
                        if (numara == kisiler[i].number)
                        {
                            Console.WriteLine(" Arama Sonuçlarınız:");

                            Console.WriteLine("**********************************************");

                            Console.WriteLine(" isim: {0}", kisiler[i].ad);
                            Console.WriteLine(" Soyisim: {0}", kisiler[i].soyad);
                            Console.WriteLine("  Telefon Numarası: {0}", kisiler[i].number);

                        }
                    }
                }


            }
            void Silme()
            {
            geri:
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string ad = Console.ReadLine();
                bool onay = false;

                for (int i = 0; i < kisiler.Count; i++)
                {
                    if (ad == kisiler[i].ad || ad == kisiler[i].soyad)
                    {
                        onay = true;
                        Console.WriteLine(" {0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", ad);
                        char tf = char.Parse(Console.ReadLine());
                        if (tf == 'y')
                        {
                            kisiler.RemoveAt(i);
                            Listeleme();
                        }

                    }
                }
                if (onay == false)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("  * Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("  * Yeniden denemek için      : (2)");
                    int karar = int.Parse(Console.ReadLine());
                    if (karar == 2)
                    {
                        goto geri;
                    }
                }

            }
            void Guncelle()
            {
                back:
                Console.WriteLine("  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string adsoyad = Console.ReadLine();
                bool onay =false;

                for (int i = 0; i < kisiler.Count; i++)
                {
                    if (adsoyad==kisiler[i].ad || adsoyad == kisiler[i].soyad)
                    {
                        onay = true;
                          kisiler.RemoveAt(i);
                        Ekleme();
                        
                    }
                }
                if (onay==false)
                {
                    
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. ");
                    Console.WriteLine("Lütfen bir seçim yapınız.");
                    Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)");
                    Console.WriteLine(" * Yeniden denemek için              : (2)");
                    int yn=int.Parse(Console.ReadLine());
                    if (yn==2)
                    {
                        goto back;
                    }
                    
                }                
            }
        }

    }


    class Rehber
    {
        public string ad;
        public string soyad;
        public long number;

        public Rehber(string ad, string soyad, long number)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.number = number;
        }
    }

}
