# 📐 Polymorphism ile Geometrik Şekiller - Alan Hesaplama

Bu proje, C# dilinde nesne yönelimli programlamanın temel kavramlarından **Polymorphism (Çok Biçimlilik)** prensibini kullanarak geometrik şekillerin alanlarını hesaplama amacıyla hazırlanmıştır.

---

## 📝 Proje Özeti

- `BaseGeometrikSekil` adında bir temel sınıf oluşturulmuştur.
- Temel sınıfta `Genislik` ve `Yukseklik` özellikleri ile `AlanHesapla()` adlı sanal (virtual) metot tanımlanmıştır.
- `Kare` ve `Dikdortgen` sınıfları, `BaseGeometrikSekil` sınıfından türetilmiş ve temel sınıfın `AlanHesapla()` metodunu olduğu gibi kullanmıştır.
- `DikUcgen` sınıfı ise `AlanHesapla()` metodunu geçersiz kılarak (override) alan hesaplamayı üçgen formülüne göre `(Genislik x Yukseklik) / 2` olarak gerçekleştirmiştir.
- Her sınıftan örnek nesneler oluşturularak alan değerleri konsola yazdırılmıştır.

---

## ⚙️ Kullanılan Teknolojiler

- Programlama Dili: **C#**
- Platform: **.NET Console Application**
- IDE: Visual Studio, Visual Studio Code veya benzeri C# destekleyen editörler

---

## 🚀 Nasıl Çalıştırılır?

1. Proje dosyasını bir C# Console uygulaması olarak açın.
2. `Program.cs` dosyasına kodları yapıştırın veya projeye dahil edin.
3. Uygulamayı çalıştırın (`Ctrl + F5` veya `dotnet run`).
4. Konsolda kare, dikdörtgen ve dik üçgenin alanları görüntülenecektir.

---

## 💡 Temel Kavramlar

- **Class (Sınıf):** Nesnelerin şablonu olarak kullanılır.
- **Inheritance (Kalıtım):** Sınıflar arasında miras ilişkisi kurar.
- **Virtual Metot:** Türetilen sınıflar tarafından özelleştirilebilen metot.
- **Override:** Sanal metodu alt sınıfta yeniden tanımlama.
- **Polymorphism:** Aynı metot isminin farklı şekillerde davranması.

---

## 📖 Örnek Çıktı

