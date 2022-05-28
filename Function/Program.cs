//  static void WriteName() { Console.WriteLine("Berkay Balon"); }


//Fonksiyon tanımlarken "public veya private ile tanımlıyoruz. Direk "static void" olarak yazdığımızda public oluyor ve her yerden erişebiliyoruz.
//Değer döndürmücek olduğumuz zaman "void" kullanıyoruz. değer döndürceksek void yazmaya gerek yok.
//Private -->  Yalnızca metodun yazıldığı classta kullanılabilir.
//Public  -->  Metod, programın tamamında kullanılabilir.
//Static  -->  Private ve Public ifadesinden sonra eklenirse metod doğrudan kullanılabilir, eklenmezse metodun bulunduğu sınıftan nesne türetilerek kullanılmak zorundadır.

//  WriteName();

//Fonksiyonun tanımı (ismi). Fonksiyonu kullanırken bu isimle çağırıyoruz.


//** İnteger döndüren fonksiyon


//  static int top(int s1, int s2) { return s1 + s2; }
//Fonksiyonu en başta tanımlarsak daha rahat ederiz bence.

//  Console.Write("1. Sayıyı Giriniz=");
//  int s1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("2. Sayıyı Giriniz=");
//   int s2 = Convert.ToInt32(Console.ReadLine());
// int s3 = top(s1, s2);
//top(s1, s2) yazdığımız yerde fonksiyonu çağırmış oluyoruz.

//  Console.Write("İşlem Sonucu=" + s3);


//** Bankadan çekilen krediyi seçilen mevduadına göre hesaplama. ( Class Açarak Ordan Çekme)

using Functions;





Console.Write("Çekmek İstediğiniz Kredi Tutarını Giriniz=");
int tutar = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1. Paket= %2 Faiz");
Console.WriteLine("2. Paket= %3 Faiz");
Console.WriteLine("3. Paket= %4 Faiz");
Console.WriteLine("4. Paket= %5 Faiz");
Console.WriteLine("5. Paket= %6 Faiz");
Console.Write("Kredi Paketini Giriniz=");

int kp = Convert.ToInt32(Console.ReadLine());

CreditsClass credits = new CreditsClass();
//sınıfı burda çağırdık. Sınıfı çağırmadan sınıfın içindeki fonksiyonu kullanamayız.

credits.installment(kp,tutar);
//Fonksiyonu çağırdık ve kullandık. Fonksiyonu kullanırken, fonksiyonda kullandığımız tüm değişkenleri parantez içinde tanımlıyoruz.
















