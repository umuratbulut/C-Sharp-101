using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            // Foreach
            int[] sayiDizisi = { 2, 4, 5, 1, 2, 4 };
            int toplam = 0;

            foreach (int i in sayiDizisi)
            {
                toplam += i;
            }

            Console.WriteLine(toplam);
        }
    }
}
