# Constructor

* Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.

```csharp

    class EmployeManager
    {
        public EmployeManager()
        {
            //Constructor Metodumuzun Kod İçeriğinin Yer Alacağı Yer.
        }
    }

```

* Kurucu eetot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:
    * Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
    * Public olarak bildirilmeleri gerekir.
    * Geri dönüş değerleri yoktur.

* Kurucu metotların imzasını değiştirerek overload edebiliriz yani aşırı yükleyebiliriz.

```csharp

    class EmployeManager
    {
        public EmployeManager()
        {
            //Constructor Metodumuzun Kod İçeriğinin Yer Alacağı Yer.
        }
        public EmployeManager(string name, string surName)
        {
            // Parametre Alan Constructor Metodumuzun Kod İçeriğinin Yer Alacağı Yer.
        }
    }

```  

### Varsayılan Kurucu Metot

* Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.

* Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda null olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.