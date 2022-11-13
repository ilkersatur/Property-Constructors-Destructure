using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._10._2022
{   
    //class members(sınıf üyeleri)---bir sınıfın içerisinde olabilen yapılar
    //1-değişken
    //2-metodlar
    internal class Personel
    {
        //sınıf seviyesinde varsayılan erişim belirleyicisi private dır.

        /// <summary>
        /// encapsulation der ki ----> bir sınıf içerisindeki değişkenleri dışarıya kapat!!
        /// </summary>
       //public int sayi;
        private int sayi; //sayi değişkenini gizledik

        public void Set_Sayi(int s)
        {
            sayi = s;
        }
        public int Get_Sayi()
        {
            return sayi;
        }
        public void Islem()
        {

        }
        //c# 3.0 öncesi property tanımlama
        // değişken ismi ile özellik ismi aynı olmaz
        //özelliğin kullnacaağı değişken mutlaka tanımlanmalıdır
        private string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        //C# 3.0 SONRASI ihtayıcı olan değişkeni kendisi oluşturur
        public string AD { get; set; } // property değer alıp değer verir , aracı gibidir 
        //---- burada get ve set lere komut yazılmaz

        //encapsulation neden değişkenler için aracı(property) kullanın der?----> veri tutarlılığı için ; girilen değerleri özellik
        //üzerinden kontrol edebiliriz

        // eğer property içerisine kod yazılacaksa 3.0 öncesi yazmak gerekir ya da c#10 ile gelen semi-auto property

        string sicilNo;
        public string SicilNo
        {
            get { return sicilNo; }
            set
            {
                if (value.Contains('A'))
                    sicilNo = "Geçersiz";
                else
                    sicilNo = value;
            }
        }
    }
}
