using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyManyMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            //bilgisayar B1 = new bilgisayar();
            ////B1.id = 1;
            //B1.marka = "lenova";
            //B1.model = "z50";
            //B1.işlemci = "I5";
            //B1.alisFiyat = -1;
            //B1.satisFiyat = 1000;
            //B1.kampanyaFiyat = 1500;
            //B1.barkod = "1324498525";

            //bilgisayar B2 = new bilgisayar();
            ////B1.id = 1;
            //B2.marka = "lenova";
            //B2.model = "z50";
            //B2.işlemci = "I5";
            //B2.alisFiyat = -1;
            //B2.satisFiyat = 1000;
            //B2.kampanyaFiyat = 1500;
            //B2.barkod = "1324498525";

            //sanalDataBase.yeniUrunEkle(B2);

            Musteri M1 = new Musteri();
            M1.isim = "cengiz";
            M1.soyisim = "Atilla";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj);



        }
    }
}
