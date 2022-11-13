//4-constructors(ctor) ---- yapıcı inşa veya edici metodalar
//5-deconstructor(destructure)----- yıkıcı metodlar


using Constructors;

Musteri musteri = new Musteri(); // compiler tüm sınıflar için varsayılan olarak ctor olustutur...Default ctor
//fakat  biz parametrik bir ctor oluşturursak compiler varsayılan ctoru yazmaz
//varsayılan ctor ların parametresi olmaz

//bir sınıf ram de oluşturulurken ilk çalışan metoda ctor denir (konstraktır)
// bir sınıfta imazaları farklı olmak kaydıyla n tane ctor olabilir
//bir sınıf ramden silinirken de en son çalışan metoda destructure denir (dikonstraktır)
//bir sınıf içerisinde sadece 1 tane destructure

//ctor neden kullanılır?
/*
 * bir sınıfa ilk değer ataması yapmak için kullanılır --- artık çok kullanılmıyor
 * bir sınıf oluşturulurken belirli işlemleri yaptırmak için kullanılır
 * * * * * Bunu kesin öğren * * * * *  bir sınıf oluşturulurken kullanıcığı birşeylere zorlamak içinde kullanılır...(parametrik 
 * değerlere zorlamak için)
 * 
 */
//instance aldığımız ctor çalışır
//ctor ları new Müsteri() den sonra görebiliriz
Musteri musteri2 = new Musteri(12);
