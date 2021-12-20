using System;

namespace If_Else_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
                Console.WriteLine("Girdiğiniz sayı 0'dan büyük.");
            else
                Console.WriteLine("Girdiğiniz sayı 0'dan küçük.");
            // Ternary
            int c = a > 0 ? a : 0;
            Console.WriteLine(c);
        }
    }
}
