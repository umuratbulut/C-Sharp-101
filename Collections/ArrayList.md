# ArrayList

```csharp
	
    /* Array nesnesinde bütün veri tiplerindeki değerleri tutabiliriz. */
    ArrayList ary = new ArrayList();
            ary.Add("Ferrari");
            ary.Add(3);
            ary.Add("Honda");
            ary.Add('D');
            ary.Add("Chris");
            ary.Add(true);

    /* Eğer aşağıdaki gibi Capacity(kapasitesini verir) özelliğini kullanırsanız,her dört elemanda bir kapasitenin 2’nin kuvvetleri şeklinde arttığını göreceksiniz.*/
    int a = ary.Capacity;
    MessageBox.Show(a.ToString());

    /* Buradaki ToArray() metodu,ary adlı ArrayList yapısındaki verileri,object türden dizi değişkenine atmamıza yardımcı oldu.*/
    object[] objekt = ary.ToArray(); 

```