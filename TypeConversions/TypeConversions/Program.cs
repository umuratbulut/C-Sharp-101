using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit

            byte a = 5;
            short b = 10;
            sbyte c = 30;
            int d = a + b + c;
            string e = "deneme";
            char f = 'k';
            object g = e + f + d;
            long h = d;
            float i = h;
            double j = i;
            double k = 12.5f;
            Console.WriteLine(j + k);

            // Explicit

            int veri = 5;
            byte b1 = (byte)veri;
            Console.WriteLine(b1);
        }
    }
}
