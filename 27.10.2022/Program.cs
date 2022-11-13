//int sayi = 0;
//while (true)
//{
//    Thread.Sleep(500);
//    sayi++;
//    Console.Write(sayi);
//    Thread.Sleep(500);
//    Console.Clear();
//}

//OOP DEVAM
using _27._10._2022;

Personel p = new Personel();

// referans değişkeni = new - heap bölgesinde yer açar -------- personel() kurucu metod , ctor
//p.sayi = 12;
//Console.WriteLine(p.sayi);------------ sayı değişkeninin erişim belirleyicisi private olarak değişti
//p.Islem();
p.Set_Sayi(111);
Console.WriteLine(p.Get_Sayi());

//3-Property

p.SicilNo = "A123";
Console.WriteLine(p.SicilNo);

p.SicilNo = "gh523";
Console.WriteLine(p.SicilNo);