using System;
using System.Collections;
using System.Collections.Generic;
namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //         Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın


            ArrayList asalsayilar = new ArrayList();
            ArrayList asaldegil = new ArrayList();
            islemler islem = new islemler();
            float toplamasal = 0;
            float toplam = 0;
            try
            {
                for (int ba = 0; ba < 20; ba++)
                {
                    int kontrol = 0;
                    Console.Write("{0}. Sayıyı Giriniz : ",ba+1);

                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi <= 0)
                        Console.WriteLine("Pozitif değerr giriniz");
                    else
                        if (sayi == 1 || sayi == 0 || sayi == 4)
                    {
                        
                        asaldegil.Add(sayi);

                    }
                    else
                    {
                        for (int i = 2; i < sayi / 2; i++)
                        {
                            if (sayi % i == 0)
                            {
                                kontrol++;
                                break;
                            }


                        }

                        if (kontrol != 0)
                        {

                            asaldegil.Add(sayi);
                        }

                        else
                        {

                            asalsayilar.Add(sayi);
                        }
                    }

                }
                islem.sirala(asalsayilar);
                islem.sirala(asaldegil);
                Console.WriteLine("****** Asal sayılar ******");
                for (int i = 0; i < asalsayilar.Count; i++)
                {
                    toplamasal = toplamasal + Convert.ToInt32(asalsayilar[i]);

                    Console.WriteLine(asalsayilar[i]);
                }
                Console.WriteLine("Asal sayıların ortalaması:" + toplamasal / asalsayilar.Count);

                Console.WriteLine("***** Asal olmayan ******");
                for (int i = 0; i < asaldegil.Count; i++)
                {
                    toplam = toplam + Convert.ToInt32(asaldegil[i]);
                    Console.WriteLine(asaldegil[i]);
                }
                Console.WriteLine("Asal olmayan sayıların ortalaması: "  + toplam / asaldegil.Count);



            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message.ToString());
            }

        }
        public class islemler
        {
            public ArrayList sirala(ArrayList sortting)
            {
                sortting.Sort();
                return sortting;
            }


        }
    }
}
