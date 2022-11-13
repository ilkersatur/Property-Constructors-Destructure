// bir kitap nesnesi oluşturup id , ad , yazar , kategori , fiyat bilgilerini tutup en az iki metod yazınız?
// porpertylerden biri c# 3.0 öncesi olmalı-- ayrıca kitap nesnesinden 5 adet oluşturunuz.

using Ornek_I;

Kitap kitap1 = new Kitap();
kitap1.Yazar = "Stephen Hawking";
kitap1.Ad = "Ceviz Kabuğundaki Evren";
kitap1.Fiyat = 39.90;
kitap1.Id = 19;
kitap1.Kategori = "Bilim";

Kitap kitap2 = new Kitap() { Kategori = "Fizik", Ad = "İzafiyet Teorisi", Fiyat = 53.23, Yazar = "Albert Einstein", Id = 23 };

Kitap kitap3 = new Kitap()
{
    Kategori = "Roman",
    Ad = "Zamanın Kısa Tarihi",
    Fiyat = 43.00,
    Yazar = "Stephen Hawking",
    Id = 81

};

Console.WriteLine($"birinci kitaba ait özellikler ---> {kitap1.EkranaYaz()}");
Console.WriteLine($"ikinci kitaba ait özellikler ---> {kitap2.EkranaYaz()}");
Console.WriteLine($"üçüncü kitaba ait özellikler ---> {kitap3.EkranaYaz()}");