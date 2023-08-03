using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS3ODEVİ
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri) {

            Console.WriteLine( musteri.musteriAD + " İsimli Müşteri Eklendi...");

        }
        public void Sil(Musteri musteri)
        {

            Console.WriteLine(musteri.musteriAD + " İsimli Müşteri Silindi...");

        }

        public void Guncellendi(Musteri musteri)
        {

            Console.WriteLine(musteri.musteriAD + " İsimli Müşteri Güncellendi...");

        }


    }
}
