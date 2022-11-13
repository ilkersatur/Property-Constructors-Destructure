using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_I
{
    internal class Kitap
    {
        private string ad;
        private int id;
        private string yazar;
        private string kategori;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Yazar
        {
            get { return yazar; }
            set { yazar = value; }
        }
        public string Kategori //propfull tab tab
        {
            get { return kategori; }
            set { kategori = value; }
        }
        //3.0 sonrası
        public double Fiyat { get; set; } //prop tab tab
        public string EkranaYaz()
        {
            return $"id= {id} yazar= {yazar}\nkitap ismi= {ad} \nkategori= {kategori} fiyat= {Fiyat}TL";
        }
    }
}
