using System;
using System.Threading;

internal class Program
{

    static void Main(string[] args)
    {

        // задаем тип данных
        string type;
        string ret;

        // проверка повторного запуска проги
        ret = "да";
        while (ret == "да")
        {

            // задаем тип данных
            string sym;
            int x;
            int y;
            int slp;

            // выбираем фигуру
            Console.WriteLine("Прямоугольник - 1");
            Console.WriteLine("Треугольник - 2");
            type = Console.ReadLine();
            Console.WriteLine();

            switch (type)
            {
                // не правильно выбранна фигура
                default:
                    Console.WriteLine("Ошибка! Не выбранна фигура.");
                    Console.WriteLine();
                    break;

                case "1":

                    // выбираем параметры прамоугольника
                    Console.WriteLine("Введите символ из которого будет построен прямоугольник:");
                    sym = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Введите высоту:");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Введите ширину:");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Введите время в милмисикундах:");
                    slp = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    // постройка прамоугольника
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
                    break;

                case "2":
                    
                    // выбираем параметры треугольников
                    Console.WriteLine("Введите символ из которого будут построены треугольники:");
                    sym = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Введите высоту:");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Введите время в милмисикундах:");
                    slp = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    // первый треугольник
                    x = 0;
                    for (int a = 0; a <= y; a++)
                    {
                        for (int b = 0; b < x; b++)
                        {
                            Console.Write(sym);
                            Thread.Sleep(slp);
                        }

                        Console.WriteLine();
                        ++x;
                        Thread.Sleep(slp);
                    }
                    Console.WriteLine();

                    // второй треугольник
                    x = y;
                    for (int a = 0; a <= y; a++)
                    {
                        Console.WriteLine();
                        for (int b = 0; b < x; b++)
                        {
                            Console.Write(sym);
                            Thread.Sleep(slp);
                        }
                        Thread.Sleep(slp);
                        --x;
                    }
                    Console.WriteLine();

                    // третий треугольник
                    x = y;
                    for (int a = 0; a <= y; a++)
                    {
                        for (int b = 0; b < x; b++)
                        {
                            Console.Write(" ");
                            Thread.Sleep(slp);
                        }
                        for (int c = 0; c < a; c++)
                        {
                            Console.Write(sym);
                            Thread.Sleep(slp);
                        }
                        Console.WriteLine();
                        --x;
                        Thread.Sleep(slp);
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    // четвертый треугольник
                    x = y;
                    for (int a = 0; a <= y; a++)
                    {
                        for (int b = 0; b < a; b++)
                        {
                            Console.Write(" ");
                            Thread.Sleep(slp);
                        }
                        for (int c = 0; c < x; c++)
                        {
                            Console.Write(sym);
                            Thread.Sleep(slp);
                        }
                        Thread.Sleep(slp);
                        Console.WriteLine();
                        --x;
                    }
                    break;

            // выбираем повторить программу или нет
            }
            Console.WriteLine("Запустить программу заного?");
            ret = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
