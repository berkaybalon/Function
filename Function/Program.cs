// static void WriteName() { Console.WriteLine("Berkay Balon"); }


//Fonksiyon tanımlarken "public veya private ile tanımlıyoruz. Direk "static void" olarak yazdığımızda public oluyor ve her yerden erişebiliyoruz.
//Değer döndürmücek olduğumuz zaman "void" kullanıyoruz. değer döndürceksek void yazmaya gerek yok.
//Private -->  Yalnızca metodun yazıldığı classta kullanılabilir.
//Public  -->  Metod, programın tamamında kullanılabilir.
//Static  -->  Private ve Public ifadesinden sonra eklenirse metod doğrudan kullanılabilir, eklenmezse metodun bulunduğu sınıftan nesne türetilerek kullanılmak zorundadır.

// WriteName();

//Fonksiyonun tanımı (ismi). Fonksiyonu kullanırken bu isimle çağırıyoruz.


//** İnteger döndüren fonksiyon


static int top(int s1, int s2) { return s1 + s2; }
//Fonksiyonu en başta tanımlarsak daha rahat ederiz bence.

Console.Write("1. Sayıyı Giriniz=");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Sayıyı Giriniz=");
int s2 = Convert.ToInt32(Console.ReadLine());
int s3 = top(s1, s2);
// top(s1, s2) yazdığımız yerde fonksiyonu çağırmış oluyoruz.

Console.Write("İşlem Sonucu=" + s3);











