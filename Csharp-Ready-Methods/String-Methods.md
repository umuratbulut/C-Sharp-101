# String Methods

```csharp
    string metin="Patika.dev";

    bool b = metin.Contains("nç");//metin stringinde "nç" var mı yok mu?
    Consol.Write(b); //True değerini döndürecektir.

    bool b = metin.EndsWith("asd");//metin stringinin sonunda "asd" var mı?
    Console.WriteLine(b);//Olmadığından dolayı False değeri dönecektir.

    bool b = metin.StartsWith("G");//metin stringi "G" ile başlıyor mu?
    Console.WriteLine(b);//True yazacaktır.

    metin = metin.Insert(2, "asd");/*metin değişkenindeki değerin 2.
    indexinden itibaren "asd" kelimesini ekle.*/
    Console.WriteLine(metin);
    //Görüntü olarak "Geasdnçay" kelimesi yazılacaktır.

    metin.Remove(4); // 4. indexten itibaren sil.
    metin.Remove(2,3); // 2. indexten itibaren 4 karakter sil.
    metin.Replace(‘bu değerleri’,’buna cevir’); // Bu metod iki parametre almaktadır.Birincisine değiştirilmek istenen karakter,ikincisine yerine getirilecek karakterdir.

    metin = metin.Replace('ç','.');//"ç" leri "." yap
    Console.WriteLine(metin);

    metin = metin.Substring(4); //Ay yazacaktır.
    Console.WriteLine(metin);
    
    metin = metin.Substring(2,2);//nç yazacaktır.
    Console.WriteLine(metin);

    metin.ToLower(); // Bütün harfleri küçük yapar.
    metin.ToUpper(); // Bütün harfleri büyük yapar.

    string metin = "Patika, dev, 2021";//"," ayraç olarak kullanıyoruz.
    string[] metin2 = metin.Split(',');/*metin2 dizi değişkenine Split
    metoduyla "," ayraç göstererek kelimeleri teker teker alıyorum.*/
    for (int i = 0; i < metin2.Length; i++)
    {
        Console.WriteLine(metin2[i]);
    }

    metin.Trim(); // metin değişkeninin başındaki ve sonundaki boşlukları siler.
    metin.TrimEnd(); // metin değişkeninin sonundaki boşlukları siler.
    metin.TrimStart(); // metin değişkeninin başındaki boşlukları siler.

```