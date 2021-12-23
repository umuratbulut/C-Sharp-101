# Extension & Recursive Methods

```csharp

static class Program
{
    static int FibonacciSerisi(int sayi)
    {  
        if (sayi==0)
            return 0;
        elseif (sayi==1)
            return 1;
        else
            return FibonacciSerisi(sayi-1)+FibonacciSerisi(sayi-2);
    }

    static bool IsEventNumber(this int value)
    {
        if(value%2==0)
            return true;
        else
            return false;
    }

    static void Main(string[] args)
    {
        int deger = 123;
        bool isEven = deger.IsEvenNumber();
        Console.Write("Sonuç= {0}",isEven);
    }
}

```
