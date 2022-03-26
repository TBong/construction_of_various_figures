using System;

namespace square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ из которого будет построен прямоугольник:");
            string sym = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите высоту:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите ширину:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите время в милмисикундах:");
            int slp = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int a = 0; a < y; a++)
            {
                for (int b = 0; b < x; b++)
                {
                    Console.Write(sym);
                    Thread.Sleep(slp);
                }
                Console.WriteLine();
                Thread.Sleep(slp);
            }
        }
    }
}
