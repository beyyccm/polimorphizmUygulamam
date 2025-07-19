using System;

// Base sınıf
class BaseGeometrikSekil
{
    // Özellikler
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    // Sanal (virtual) metot: Alan hesaplama
    public virtual double AlanHesapla()
    {
        // Kare ve Dikdörtgen için standart alan formülü
        return Genislik * Yukseklik;
    }
}

// Kare sınıfı, BaseGeometrikSekil’den türetilir
class Kare : BaseGeometrikSekil
{
    // Kare için base metodunu kullanabiliriz (override gerekmez)
    // Çünkü alanı Genislik x Yukseklik = Kenar x Kenar şeklindedir
}

// Dikdörtgen sınıfı, BaseGeometrikSekil’den türetilir
class Dikdortgen : BaseGeometrikSekil
{
    // Dikdörtgen için de base metodunu kullanabiliriz
}

// DikÜçgen sınıfı, BaseGeometrikSekil’den türetilir
class DikUcgen : BaseGeometrikSekil
{
    // Alan hesaplama metodu override edilir
    public override double AlanHesapla()
    {
        // Dik üçgen alan formülü: (Genişlik x Yükseklik) / 2
        return (Genislik * Yukseklik) / 2;
    }
}

// Program giriş noktası
class Program
{
    static void Main(string[] args)
    {
        // Kare nesnesi oluşturma
        Kare kare = new Kare();
        kare.Genislik = 5;
        kare.Yukseklik = 5; // Karede Genislik ve Yukseklik eşit olabilir
        Console.WriteLine($"Kare Alanı: {kare.AlanHesapla()}");

        // Dikdörtgen nesnesi oluşturma
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.Genislik = 6;
        dikdortgen.Yukseklik = 4;
        Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.AlanHesapla()}");

        // Dik Üçgen nesnesi oluşturma
        DikUcgen dikUcgen = new DikUcgen();
        dikUcgen.Genislik = 6;
        dikUcgen.Yukseklik = 4;
        Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen.AlanHesapla()}");
    }
}
