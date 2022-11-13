using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Musteri
    {
        // ctor nasıl yazılır
        //1-Sınıf adı ile aynı isimde olurlar
        //2- return type yoktur
        public Musteri()
        {
            Console.WriteLine("nesne oluştu");
        } //ctor tab tab
        public Musteri(string s)
        {
            Console.WriteLine("obje oluştu");
        }
        public Musteri(int s)
        {
            Console.WriteLine("object oluştu");
        }
        ~Musteri()
        {
            //destructure
        }
    }
}
