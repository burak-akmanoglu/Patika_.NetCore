using System;
namespace Cards
{
   class Cards
    {
        public string baslik;
        public string icerik;
        public string kisi;

        public int size;
        public int KolonId;
        public Cards(string baslik, string icerik, string kisi, int size, int KolonId)
        {
            this.baslik = baslik;
            this.icerik = icerik;
            this.kisi = kisi;
            this.size = size;
            this.KolonId = KolonId;
        }

    }   
}

