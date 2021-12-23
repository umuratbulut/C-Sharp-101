# Method Overload

```csharp

static class Program
{
    static int ArttırVeTopla (ref int x, ref int y)
    {
        x+=1;
        y+=y;
        return (x+y);     
    }

    static int ArttırVeTopla (ref int x, ref int y, ref int z)
    {
        x+=1;
        y+=y;
        z+=x;
        return (x+y+z);     
    }

    static void Main(string[] args)
    {
        int x = 3;
        int y = 4;
        int sonuc = Program.ArttırVeTopla(ref x, ref y);
        int sonuc2 = Program.ArttırVeTopla(ref x, ref y, ref z);

        Console.WriteLine("İkili işlemin sonucu= {0}",sonuc);
        Console.WriteLine("Üçlü işlemin sonucu= {0}",sonuc2);

    }
}

```
