using System;
using System.Collections.Generic;


namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kolon.Kolon> todo = new List<Kolon.Kolon>();
            todo.Add(new Kolon.Kolon(1, "Todo"));
            todo.Add(new Kolon.Kolon(2, "Inprogres"));
            todo.Add(new Kolon.Kolon(3, "Done"));

            Dictionary<int, string> kullanici = new Dictionary<int, string>();
            kullanici.Add(1, "Burak");
            kullanici.Add(2, "Ali");
            kullanici.Add(3, "Bilal");

            List<Cards.Cards> kartlar = new List<Cards.Cards>();
            kartlar.Add(new Cards.Cards("Görev", "Dersler", "Burak", 1, 0));
            kartlar.Add(new Cards.Cards("Görev1", "Dersler", "Burak", 1, 1));
            kartlar.Add(new Cards.Cards("Görev2", "Dersler", "Burak", 1, 0));
            kartlar.Add(new Cards.Cards("Görev3", "Dersler", "Burak", ((int)Size.Size.XS), 0));


            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("  (1) Board Listelemek");
            Console.WriteLine("  (2) Board'a Kart Eklemek");
            Console.WriteLine("  (3) Board'dan Kart Silmek");
            Console.WriteLine("  (4) Kart Taşımak");

            int sayi = int.Parse(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Listeleme();
                    break;
                case 2:
                    Ekleme();
                    break;
                case 3:
                    Silme();
                    break;
                case 4:
                    Tasi();
                    break;
            }
            void Ekleme()
            {
                Console.WriteLine("Başlık Giriniz                                  : ");
                string baslik = Console.ReadLine();
                Console.WriteLine("İçerik Giriniz                                  :");
                string icerik = Console.ReadLine();
                Console.WriteLine(" Kişi Seçiniz                                    :");
                string kisi = Console.ReadLine();
                Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                int size = int.Parse(Console.ReadLine());
                kartlar.Add(new Cards.Cards(baslik, icerik, kisi, size, 0));
                Listeleme();

            }
            void Silme()
            {
            back:
                bool onay = false;
                Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                Console.WriteLine(" Lütfen kart başlığını yazınız:  ");
                string baslik = Console.ReadLine();
                for (int i = 0; i < kartlar.Count; i++)
                {
                    if (baslik == kartlar[i].baslik)
                    {
                        onay = true;
                        kartlar.RemoveAt(i);
                    }
                }
                if (onay == false)
                {

                    Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi == 2)
                    {
                        goto back;
                    }

                }
                Listeleme();

            }
            async void Tasi()
            {
                 back:
                bool onay = false;
                
                Console.WriteLine(" Lütfen kart başlığını yazınız:  ");
                string baslik = Console.ReadLine();
                for (int i = 0; i < kartlar.Count; i++)
                {
                    if (baslik == kartlar[i].baslik)
                    {
                        onay = true;
                      Console.WriteLine("Bulunan Kart Bilgileri:");
                      Console.WriteLine(" **************************************");
                      Console.WriteLine("Başlık      :{0}",kartlar[i].baslik);
                      Console.WriteLine("İçerik      :{0}",kartlar[i].icerik);
                      Console.WriteLine("Atanan Kişi :{0}",kartlar[i].kisi);
                      Console.WriteLine("Büyüklük    :{0}",kartlar[i].size);
                      Console.WriteLine("Line        :{0}",kartlar[i].KolonId);

                      
                      Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                      Console.WriteLine(" (1) TODO");
                      Console.WriteLine(" (2) IN PROGRESS");
                      Console.WriteLine(" (3) DONE");
                      int sayi= int.Parse(Console.ReadLine());

                      if (sayi==1)
                      {
                          kartlar[i].KolonId=0;
                      }
                      if (sayi==2)
                      {
                          kartlar[i].KolonId=1;
                      }
                      if (sayi==3)
                      {
                          kartlar[i].KolonId=2;
                      }
                      Listeleme();

                      
                    }
                }
                if (onay == false)
                {

                    Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi == 2)
                    {
                        goto back;
                    }

                }
            }


            void Listeleme()
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                        Console.WriteLine(" TODO Line");

                    if (j == 1)
                        Console.WriteLine("IN PROGRESS Line");

                    if (j == 2)
                        Console.WriteLine("  DONE Line");
                    Console.WriteLine("************************");
                    for (int i = 0; i < kartlar.Count; i++)
                    {
                        if (kartlar[i].KolonId == j)
                        {

                            Console.Write(" Başlık      :");
                            Console.WriteLine(kartlar[i].baslik);
                            Console.Write(" İçerik      :");
                            Console.WriteLine(kartlar[i].icerik);
                            Console.Write(" Atanan Kişi :");
                            Console.WriteLine(kartlar[i].kisi);
                            Console.Write(" Büyüklük    :");
                            Console.WriteLine(kartlar[i].size);
                            Console.Write("-");
                        }
                    }
                }




            }


        }
    }



}
