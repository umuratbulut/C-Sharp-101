using System;

namespace Variables_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 255;
            sbyte mySbyte = -128;
            short myShot = -32767;
            ushort myUshort = 65535;
            int myInt = -15688;
            uint myUint = 15688;
            long myLong = -32574698;
            ulong myUlong = 32574698;
            // -> Ondalıklı Sayı Alanlar:
            float myFloat = 64.231321f;
            double myDouble = 1233.875157421;
            decimal myDecmial = 127.52132M;
            // -> Diğer Primitive Veri Tipleri:
            char myChar = '-';
            Boolean myBoolean = true;
            // Referans Veri Tipleri:
            string myWeb = "www.example.com.tr", myText = "Merhaba!";
            // Konsola Yazdırma Komutları:
            Console.WriteLine(myText + "\n" + new string('-', 20)); // 20 Adet "-" işaretini koyacak yan yana.
            Console.WriteLine("-> Tam Sayılar:" + "\nByte Değeri: " + myByte + "\t SByte Değeri: " + mySbyte + "\nShort Değeri: " + myShot + "\tUShort Değeri: " + myUshort);
            Console.WriteLine("Integer Değeri: " + myInt + "\t UInteger Değeri: " + myUint + "\nLong Değeri: " + myLong + "\tULong Değeri: " + myUlong);
            Console.WriteLine(new string('-', 20) + "\n-> Ondalıklı Sayılar:");
            Console.WriteLine("Float Değeri: " + myFloat + "\nDouble Değeri: " + myDouble + "\nDecmial Değeri: " + myDecmial);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Booelan Değeri: " + myBoolean + "\nWeb Sitem " + myChar + " " + myWeb);
        }
    }
}
