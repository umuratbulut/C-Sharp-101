# Generic Collections

```csharp
	
    List<string> liste = new List<string>();
    liste.Add("Patika");   //Doğru
    liste.Add("dev");   //Doğru
    /*Lliste koleksiyonu sadece string tipten veri aldığı için
    başkabir tipteki veriyi eklemeye çalışında derleyici direkt hata verecektir.*/
    liste.Add(12);         //Yanlış
    liste.Add(new Araba());//Yanlış

    Dictionary<string,int> Dlist = new Dictionary<string,int>();
    Dlist.Add("Doğum Yılı : ",1992);   //Doğru
    Dlist.Add("Yaşı", 20);             //Doğru
    Dlist.Add("Adı","Luli");         //Yanlış
    Dlist.Add(123,"Example");           //Yanlış
    //Yanlış değerler koleksiyona eklenmeye çalışıldığı anda derleyici hata verecektir.

```