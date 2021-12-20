using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 - 4 arasında bir sayı giriniz:");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Mclaren");
                    break;
                case 2:
                    Console.WriteLine("Bugatti");
                    break;
                case 3:
                    Console.WriteLine("Koeingsegg");
                    break;
                case 4:
                    Console.WriteLine("Ferrari");
                    break;
                default:
                    Console.WriteLine("Girdiğiniz sayı hatalı!");
                    break;
            }

        }
    }
}
