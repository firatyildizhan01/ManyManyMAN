using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyManyMAN
{
    class Urun : baseClass
    {
        public string marka { get; set; }
        public string model { get; set; }

        private decimal _alisFiyatı;
        public decimal alisFiyat
        {

            get { return _alisFiyatı; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alis fiyatı 0 dan küçük veya eşit olamaz");
                }
                else
                {
                    _alisFiyatı = value;
                }

            }
        }

        private decimal _satisFiyatı;
        public decimal satisFiyat
        {
            get { return _satisFiyatı; }

            set
            {
                if (value < _alisFiyatı)
                {
                    Console.WriteLine("ürünün satış fiyatı alış fiyatına küçük olamaz...");
                }
                else
                {
                    _satisFiyatı = value;
                }
            }
        }
        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get { return _kampanyaFiyat; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("kampanya fiyatı 0 dan küçük veya eşit olamaz...");
                }
            }
        }




    }
}
