using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Program
    {
        public static class Circle
        {
            public static double length;
            public static double square;
            public static double distance;

            public static double GetCircleLength(double radius)
            {
                length = 2 * Math.PI * radius;
                return length;
            }

            public static double GetCircleSquire(double radius)
            {
                square = Math.PI * radius * radius;
                return square;
            }
            public static bool BelongToCircle(double radius, double x0, double y0, double x, double y)
            {
                x0 = Math.Abs(x0);
                y0 = Math.Abs(y0);
                x = Math.Abs(x);
                y = Math.Abs(y);
                distance = Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0));
                if (distance <= radius)
                    return true;
                else
                    return false;
            }
        }

        static void Main(string[] args)
        {
            double r, l, s, x0, y0, x, y;

            Console.WriteLine("Ваc приветствует программа для работы с окружностью )");
            Console.WriteLine();

            switch (Selection())
            {
                case 1:
                    {
                        r = EnterRadius();
                        l = Circle.GetCircleLength(r);
                        Console.WriteLine();
                        Console.WriteLine("Длина окружности с радиусом {0} равна {1:F2}", r, l);
                        Console.Write("Нажмите любую клавишу для выхода...");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        r = EnterRadius();
                        s = Circle.GetCircleSquire(r);
                        Console.WriteLine();
                        Console.WriteLine("Площадь круга с радиусом {0} равна {1:F2}", r, s);
                        Console.Write("Нажмите любую клавишу для выхода...");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        r = EnterRadius();
                        x0 = EnterCoordinates(1);
                        y0 = EnterCoordinates(2);
                        x = EnterCoordinates(3);
                        y = EnterCoordinates(4);
                        Console.WriteLine();

                        if (Circle.BelongToCircle(r, x0, y0, x, y))
                        {
                            Console.WriteLine("Точка с координатами x={0}, y={1} принадлежит кругу с радиусом r={2} и координатами центра x0={3}, y0={4}", x, y, r, x0, y0);
                            Console.Write("Нажмите любую клавишу для выхода...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Точка с координатами x={0}, y={1} не принадлежит кругу с радиусом r={2} и координатами центра x0={3}, y0={4}", x, y, r, x0, y0);
                            Console.Write("Нажмите любую клавишу для выхода...");
                            Console.ReadKey();
                        }
                        break;
                    }
            }
        }

        static byte Selection()
        {
            bool error;
            byte selection = 1;

            Console.WriteLine("Выберите номер требуемого метода для работы с окружностью:");
            Console.WriteLine("1 - определение длины окружности по заданному радиусу");
            Console.WriteLine("2 - определение площади круга по заданному радиусу");
            Console.WriteLine("3 - проверка принадлежности точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0");
            Console.WriteLine();

            do
            {
                try
                {
                    Console.Write("Ваш выбор: ");
                    byte select = Convert.ToByte(Console.ReadLine());
                    error = false;
                    selection = select;
                    if (select > 3 || select < 1)
                    {
                        Console.WriteLine("Ошибка! Введите номер требуемого метода в диапазоне от 1 до 3");
                        error = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    error = true;
                }
            }
            while (error != false);

            return selection;
        }

        static double EnterRadius()
        {
            bool error;
            double r = 1;

            do
            {
                try
                {
                    Console.Write("Введите радиус окружности r: ");
                    double radius = double.Parse(Console.ReadLine());
                    r = radius;
                    error = false;
                    if (radius < 0 || radius == 0)
                    {
                        Console.WriteLine("Ошибка! Введите неотрицательное/ненулевое значение");
                        error = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    error = true;
                }
            }
            while (error != false);

            return r;
        }

        static double EnterCoordinates(byte coordinate)
        {
            bool error;
            double x0 = 0;
            double y0 = 0;
            double x = 0;
            double y = 0;

            switch (coordinate)
            {
                case 1:
                    {
                        do
                        {
                            try
                            {
                                Console.Write("Bведите координату x0 центра окружности: ");
                                double X0 = double.Parse(Console.ReadLine());
                                x0 = X0;
                                error = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка! {0}", ex.Message);
                                error = true;
                            }
                        }
                        while (error != false);

                        return x0;
                    }
                case 2:
                    {
                        do
                        {
                            try
                            {
                                Console.Write("Bведите координату y0 центра окружности: ");
                                double Y0 = double.Parse(Console.ReadLine());
                                y0 = Y0;
                                error = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка! {0}", ex.Message);
                                error = true;
                            }
                        }
                        while (error != false);

                        return y0;

                    }
                case 3:
                    {
                        do
                        {
                            try
                            {
                                Console.Write("Bведите координату x точки: ");
                                double X = double.Parse(Console.ReadLine());
                                x = X;
                                error = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка! {0}", ex.Message);
                                error = true;
                            }
                        }
                        while (error != false);

                        return x;
                    }
                case 4:
                    {
                        do
                        {
                            try
                            {
                                Console.Write("Bведите координату y точки: ");
                                double Y = double.Parse(Console.ReadLine());
                                y = Y;
                                error = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка! {0}", ex.Message);
                                error = true;
                            }
                        }
                        while (error != false);

                        return y;
                    }
            }
            return 0;
        }
    }
}
