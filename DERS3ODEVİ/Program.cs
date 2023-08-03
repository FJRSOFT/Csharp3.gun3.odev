using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS3ODEVİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Musteri musteri1 = new Musteri();
            musteri1.musteriID = 1;
            musteri1.musteriAD = "Fatih";
            musteri1.musteriSOYAD = "Taşkesen";

            Musteri musteri2 = new Musteri();
            musteri2.musteriID = 2;
            musteri2.musteriAD = "Mehmet";
            musteri2.musteriSOYAD = "Taşkesen";

            Musteri musteri3 = new Musteri();
            musteri3.musteriID = 3;
            musteri3.musteriAD = "Hülya";
            musteri3.musteriSOYAD = "Taşkesen";


            //Musteri[] musteri = new Musteri[] { musteri1, musteri2 ,musteri3};
            //foreach (Musteri gez in musteri)
            //{
            //    Console.WriteLine(gez);
                    
            //}

             MusteriManager manager = new MusteriManager();
            ////manager.Ekle(musteri1);
            ////manager.Ekle(musteri2); 
            ////manager.Ekle(musteri3);
            ////Console.WriteLine("******************");
            //manager.Sil(musteri1);
            //manager.Sil(musteri2);
            //manager.Sil(musteri3);
            Console.WriteLine("******************");
            manager.Guncellendi(musteri1);
            manager.Guncellendi(musteri2);
            manager.Guncellendi(musteri3);


        }
    }
}
