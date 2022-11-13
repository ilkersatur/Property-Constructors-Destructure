// 5 özelliği olan bir ürün sınıfı oluşturup , 3 kere kullanız

using Ornek_II;


Telefon telefon1 = new Telefon();
telefon1.Marka = "Samsung";
telefon1.Model = "Galaxy";
telefon1.Fiyat = 1200;
telefon1.Id = 1;
telefon1.AndroidSürümü = 11.1;
Telefon telefon2 = new Telefon/* istersek normal parantez kullanmayız*/{ Marka = "Apple", Model = "Iphone13", Fiyat = 3000, Id = 2, AndroidSürümü = 12.9 };
Telefon telefon3 = new Telefon()
{
    Marka = "Oppo",
    Model = "Reno6",
    Fiyat = 2500,
    AndroidSürümü = 8.0,
    Id = 3

};

Console.WriteLine($"birinci kitaba ait özellikler ---> {telefon1.EkranaYaz()}");
Console.WriteLine($"ikinci kitaba ait özellikler ---> {telefon2.EkranaYaz()}");
Console.WriteLine($"üçüncü kitaba ait özellikler ---> {telefon3.EkranaYaz()}");