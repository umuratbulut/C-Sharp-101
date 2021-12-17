using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişken Tanımlaması:
            int x = 2021, y = 5, z = 8;
            string webSite = "www.example.com.tr", webText = "Web Sitem: ";
            //Aritmetik Operatör Kullanımları:
            Console.WriteLine(new string('-', 20) + "\n-> C# Aritmetik Operatör Örnekleri");
            Console.WriteLine("-> X + Y = " + (x + y) + "\t- Toplama Operatörü"); // Toplama Operatör Kullanımı
            Console.WriteLine("-> Z - X = " + (z - x) + "\t- Çıkartma Operatörü"); // Çıkartma Operatör Kullanımı
            Console.WriteLine("-> Z * Y = " + (z * y) + "\t- Çarpma Operatörü"); // Çarpma Operatör Kullanımı
            Console.WriteLine("-> X / Y = " + (x / y) + "\t- Bölme Operatörü"); // Bölme Operatör Kullanımı
            Console.WriteLine("-> X % Y = " + (x % y) + "\t- Mod Alma Operatörü"); // Mod Alma Operatör Kullanımı
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(webText + webSite); // String metinleri birleştirme için (+) operatör kullanımı
        }
    }
}
