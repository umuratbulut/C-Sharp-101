# 1.Ödev

* __Görev 1__: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

```csharp

            Console.Write("Pozitif bir sayi giriniz ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet sayi giriniz",n);
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine("{0}.Sayıyı Giriniz;", i+1);
               int sayi = Convert.ToInt32(Console.ReadLine());
               if (sayi % 2 == 0)
                {
                    Console.WriteLine("Çift "+sayi);
                }
            }           

```

* __Görev 2__: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

 ```csharp

            Console.Write("Pozitif iki sayi giriniz ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet sayi giriniz", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz;", i + 1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                if ((sayi == m) || (sayi % m == 0))
                {

                    Console.WriteLine("Tam bölünüyor " + sayi);
                }
            }

```

* __Görev 3__: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

```csharp

           List<string> kelimeler = new List<string>();
           Console.Write("Pozitif bir sayi giriniz ");
           int n = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("{0} adet kelime giriniz", n);
           for (int i = 0; i < n; i++)
           {
                Console.WriteLine("{0}.Kelimeyi Giriniz;", i + 1);
               string kelime = Console.ReadLine();
               kelimeler.Add(kelime);
           }
           int son = kelimeler.Count - 1;
           Console.WriteLine("---sondan başa doğru kelimeler---");
           for (int i = son; i >= 0; --i)
           {
                Console.WriteLine(kelimeler[i]);
           }

```

* __Görev 4__: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

```csharp
            Console.WriteLine("Bir cümle giriniz .");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("toplam {0} tane  harf vardır.", sayac);
            Console.ReadLine();

```
