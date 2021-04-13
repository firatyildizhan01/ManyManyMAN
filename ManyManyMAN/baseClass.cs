using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyManyMAN
{
    public class baseClass
    {
        public static int sayac = 1;

        public baseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }
        
        private int _id;
        public int id { get { return _id; } 
            private set
            {
                // _id = sayac; 
                //sayac = sayac + 1; 
            } }


        private string _barkod;
        public string barkod
        {
            get { return _barkod; }

            set
            {
                bool kontrolIslemi = sanalDataBase.dbBarkodKontrol(value);
                if (!kontrolIslemi)
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("sanal database içerisinde bu barkod değeri daha önce girilmiştir");
                }
            }
        }
                
        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenkullanici { get; set; }
        public bool silindi { get; set; }




    }
}
