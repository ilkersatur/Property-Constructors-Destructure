using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_II
{
    internal class Telefon
    {
        public string Marka { get; set; }
        public int Id { get; set; }
        public string Model { get; set; }
        public double AndroidSürümü { get; set; }
        public double Fiyat { get; set; }
        public string EkranaYaz()
        {
            return $"id= {Id} marka= {Marka}\nmodel= {Model} \nAndroid Sürümü= {AndroidSürümü} fiyat= {Fiyat}TL";
        }
    }
}
