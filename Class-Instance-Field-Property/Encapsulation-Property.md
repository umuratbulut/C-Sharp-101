# Encapsulation & Property

```csharp

    class Ogrenci
    {
        private string name; //field

        public string Name //property
        {
            get { return name; }
            set { name = value; }
        }
    }

```

* Yukarıda Ogrenci sınıfı içerisinde "name" isminde private bir field tanımı görüyorsunuz. Yani bu field'a sınıf dışında bir yerden erişilemez. Altındaysa "Name" isminde "name" field'ını geri döndüren Get metodu ve "name" field ına yeni değer atamasını yapabilen bir Set metodu barındıran bir property tanımı görüyoruz.

* Burda property tanımlayarak "name" field'ını sınıf dışından yapılabilecek bilinçsiz atamalardan koruduk. Public property nin set metodu içerisinde bu field'a atanabilecek verileri kontrol edebilir ve müdahale edebiliriz.

* Aşağıdaki örnekte yaş olarak negatif bir değer atamasına engel olan property tanımını görebilirsiniz.

```csharp

    class Person
    {
        private int age=0;
        public int Age
        {
            get { return age; }
            set {
                if (value > 0)
                age = value;
            }
        }
    }

```