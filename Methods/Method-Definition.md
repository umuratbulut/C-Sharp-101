# Method Definition

```csharp

static class Program
{
    static int ArttırVeTopla (ref int x, ref int y)
    {
        x+=1;
        y+=y;
        return (x+y);     
    }

    static void Main(string[] args)
    {
        int x = 3;
        int y = 4;
        int sonuc = Program.ArttırVeTopla(ref x, ref y);
        Console.Write("İşlemin sonucu= {0}",sonuc);
    }
}

```
