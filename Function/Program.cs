WriteName();
//Fonksiyonun tanımı (ismi). Fonksiyonu kullanırken bu isimle çağırıcaz.

static void WriteName() { Console.WriteLine("Berkay Balon"); }

// Fonksiyon tanımlarken "public veya private ile tanımlıyoruz. Direk "static void" olarak yazdığımızda public oluyor ve her yerden erişebiliyoruz.
// Değer döndürmücek olduğumuz zaman "void" kullanıyoruz. değer döndürceksek void yazmaya gerek yok.
// Private -->  Yalnızca metodun yazıldığı classta kullanılabilir.
// Public  -->  Metod, programın tamamında kullanılabilir.
// Static  -->  Private ve Public ifadesinden sonra eklenirse metod doğrudan kullanılabilir, eklenmezse metodun bulunduğu sınıftan nesne türetilerek kullanılmak zorundadır.
