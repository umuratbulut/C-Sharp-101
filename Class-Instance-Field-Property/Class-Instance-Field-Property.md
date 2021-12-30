# Class, Instance, Field, Property

### Sınıf Sözdizimi, Field ve Metot Tanımlama, Erişim Belirleyiciler

* __Sınıf Nedir, Neden İhtiyaç Duyarız ?__

Sınıflar Nesne Yönelimli Programlamanın en öneeli öğesidir. C# %100 nesne yönelimli bir dil olduğu için tüm metot ve özellikler sınıflar içerisinde yer alır.

Metotlardan bahsederken bütün işlemleri tek bir metot içerisinde yazmak yerine, parçalarına yani alt metotlara ayırmak kod tekrarını azaltırken okunabilirliği arttırır demiştik. Üstelik bu şekilde yazdığınız programların daha kolay genişleyebildiğini görürsünüz.

Aynı şekilde program geliştirirken bütün metotları tek bir sınıf içerisinde yazmak yerine benzer görevleri olan metotları tek bir sınıf içerisinde toplamak en doğru yaklaşımdır.

Bir sınıfın temelde 2 tipte öğesi vardır; field/özellik ve metotlar. Aşağıda örnek bir sınıf tanımının söz dizimini görebilirsiniz.

```csharp

    class SinifAdi
    {
        [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
        [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
        {
            //Metot Gövdesi
        }
    }

```

* __Erişim Belirleyiciler__

Erişim belirleyiciler önüne geldiği öğenin projenin nerelerinden erişilebileceğini belirler. Öğeleri korur gibi düşünebilirsiniz.

1. __Public__ : Her yerden erişilebilir.

2. __Private__ : Sadece tanımlandığı sınıf içerisinden erişilebilir.

3. __Internal__ : Sadece bulunduğu proje içerisinden erişilebilir

4. __Protected__ : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

