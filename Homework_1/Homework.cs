using System;
using iHelper;

namespace Terrible
{
    public static class Homework
    {
        /// <summary>
        /// Задание первое
        /// Дни недели пронумерованы следующим образом: 0 — воскресенье,
        /// 1 — понедельник, 2 — вторник, . . . , 6 — суббота.\nДано целое число K,
        /// лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня
        /// года, если известно, что в этом году 1 января было понедельником
        /// 
        /// Ввод числа с проверкой на неправильный ввод
        /// </summary>
        public static void Integer24()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Задание первое\n" +
                $"Дни недели пронумерованы следующим образом: 0 — воскресенье,\n" +
                $"1 — понедельник, 2 — вторник, . . . , 6 — суббота.\nДано целое число K,\n" +
                $"лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня\n" +
                $"года, если известно, что в этом году 1 января было понедельником\n\n" +
                $"Ввод числа с проверкой на неправильный ввод\n");
            Console.ResetColor();

            Console.WriteLine("Введите номер дня в году:");

            int value = Function.EnterTheNumber(1, 365);

            value %= 7;



            switch (value)
            {
                case 0:
                    Console.WriteLine(DayOfTheWeek.Воскресенье);
                    break;
                case 1:
                    Console.WriteLine(DayOfTheWeek.Понедельник);
                    break;
                case 2:
                    Console.WriteLine(DayOfTheWeek.Вторник);
                    break;
                case 3:
                    Console.WriteLine(DayOfTheWeek.Среда);
                    break;
                case 4:
                    Console.WriteLine(DayOfTheWeek.Четверг);
                    break;
                case 5:
                    Console.WriteLine(DayOfTheWeek.Пятница);
                    break;
                case 6:
                    Console.WriteLine(DayOfTheWeek.Суббота);
                    break;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Даны целые положительные числа A, B, C. На прямоугольнике размера A × B 
        /// размещено максимально возможное количество квадратов со
        /// стороной C(без наложений). Найти количество квадратов, размещенных
        /// на прямоугольнике, а также площадь незанятой части прямоугольника.
        /// </summary>
        public static void Integer29()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Даны целые положительные числа A, B, C. На прямоугольнике размера A × B \n" +
                $"размещено максимально возможное количество квадратов со\n" +
                $"стороной C(без наложений). Найти количество квадратов, размещенных\n" +
                $"на прямоугольнике, а также площадь незанятой части прямоугольника.\n");
            Console.ResetColor();

            Console.WriteLine("Введите A");
            int a = Function.EnterTheNumber(0, int.MaxValue);

            Console.WriteLine("Введите B");
            int b = Function.EnterTheNumber(0, int.MaxValue);

            Console.WriteLine("Введите C");
            int c = Function.EnterTheNumber(0, int.MaxValue);

            int S1 = a * b;
            int S2 = c * c;

            int counter = S1 / S2;

            Console.WriteLine($"Площадь прямоугольника A,B: {S1}");
            Console.WriteLine($"Площадь квадрата С: {S2}");
            Console.WriteLine($"Кол-во квадратов С в прямоугольнике А,И: {counter}");
            Console.WriteLine();
        }
        /// <summary>
        /// Даны числа x, y. Проверить истинность высказывания: «Точка с
        /// координатами(x, y) лежит во второй координатной четверти».
        /// </summary>
        public static void Boolean25()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Даны числа x, y. Проверить истинность высказывания: «Точка с\n" +
                $"координатами(x, y) лежит во второй координатной четверти».\n");
            Console.ResetColor();

            Console.WriteLine("Введите число X");
            int x = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            Console.WriteLine("Введите число Y");
            int y = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            if (x < 0 && y > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Точки x: {x} и у: {y} лежат во второй координатной четверти");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Точки x: {x} и у: {y} не лежат во второй координатной четверти");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника. 
        /// Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним».
        /// </summary>
        public static void Boolean30()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника. \n" +
                $"Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним».\n");
            Console.ResetColor();

            Console.WriteLine("Введите сторону треугольника А");
            int a = Function.EnterTheNumber(0, int.MaxValue);

            Console.WriteLine("Введите сторону треугольника В");
            int b = Function.EnterTheNumber(0, int.MaxValue);

            Console.WriteLine("Введите сторону треугольника C");
            int c = Function.EnterTheNumber(0, int.MaxValue);

            if (a == b && b == c)
                Console.WriteLine("Истина");
            else
                Console.WriteLine("Ложь");

            Console.WriteLine();
        }
        /// <summary>
        /// Даны координаты двух различных полей шахматной доски x1,
        /// y1, x2, y2(целые числа, лежащие в диапазоне 1–8). 
        /// Проверить истинность высказывания: «Данные поля имеют одинаковый цвет».
        /// </summary>
        public static void Boolean35()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Даны координаты двух различных полей шахматной доски x1,\n" +
                $"y1, x2, y2(целые числа, лежащие в диапазоне 1–8). \n" +
                $"Проверить истинность высказывания: «Данные поля имеют одинаковый цвет».\n");
            Console.ResetColor();

            bool bX1 = false;
            bool bX2 = false;

            Console.WriteLine("Введите координату первого поля х1");
            int x1 = Function.EnterTheNumber(1, 8);

            Console.WriteLine("Введите координату первого поля y1");
            int y1 = Function.EnterTheNumber(1, 8);

            if (x1 % 2 == 0 && y1 % 2 == 0)
            {
                bX1 = true;
                Console.WriteLine("Цвет белый");
            }
            else if (x1 % 2 != 0 && y1 % 2 != 0)
            {
                bX1 = true;
                Console.WriteLine("Цвет белый");
            }
            else
            {
                bX1 = false;
                Console.WriteLine("Цвет черный");
            }

            Console.WriteLine("Введите координату первого поля х2");
            int x2 = Function.EnterTheNumber(1, 8);

            Console.WriteLine("Введите координату первого поля y2");
            int y2 = Function.EnterTheNumber(1, 8);

            if (x2 % 2 == 0 && y2 % 2 == 0)
            {
                bX2 = true;
                Console.WriteLine("Цвет белый");
            }
            else if (x1 % 2 != 0 && y1 % 2 != 0)
            {
                bX2 = true;
                Console.WriteLine("Цвет белый");
            }
            else
            {
                bX2 = false;
                Console.WriteLine("Цвет черный");
            }

            if (bX1 == bX2)
                Console.WriteLine("Цвета двух полей совпадают");
            else
                Console.WriteLine("Цвета двух полей не совпадают");

        }
        /// <summary>
        /// На числовой оси расположены три точки: A, B, C. Определить, какая из
        /// двух последних точек(B или C) расположена ближе к A, и вывести эту
        /// точку и ее расстояние от точки A.
        /// </summary>
        public static void If20()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"На числовой оси расположены три точки: A, B, C. Определить, какая из\n" +
                $"двух последних точек(B или C) расположена ближе к A, и вывести эту\n" +
                $"точку и ее расстояние от точки A.\n");
            Console.ResetColor();

            Console.WriteLine("Введите точку А");
            int A = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            Console.WriteLine("Введите точку B");
            int B = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            Console.WriteLine("Введите точку C");
            int C = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            if (Math.Abs(A - B) < Math.Abs(A - C))
            {
                if (A - B > 0)
                    Console.WriteLine($"Расстояние AB: {A - B}");
                else
                    Console.WriteLine($"Расстояние AB: {(A - B) * -1}");
            }
            else
            {
                if (A - C > 0)
                    Console.WriteLine($"Расстояние AC: {A - C}");
                else
                    Console.WriteLine($"Расстояние AC: {(A - C) * -1}");
            }
        }

        /// <summary>
        /// Даны целочисленные координаты трех вершин прямоугольника, стороны
        /// которого параллельны координатным осям.Найти координаты его четвертой вершины.
        /// </summary>
        public static void If23()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Даны целочисленные координаты трех вершин прямоугольника, стороны\n" +
                $"которого параллельны координатным осям.Найти координаты его четвертой вершины.\n");
            Console.ResetColor();

            Console.WriteLine("Введите точку x1");
            int x1 = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            Console.WriteLine("Введите точку y1");
            int y1 = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            Console.WriteLine("Введите точку x2");
            int x2 = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            Console.WriteLine("Введите точку y2");
            int y2 = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            Console.WriteLine("Введите точку x3");
            int x3 = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            Console.WriteLine("Введите точку y3");
            int y3 = Function.EnterTheNumber(int.MinValue, int.MaxValue);

            if (x2 == x3)
                Console.WriteLine($"Четвертая точка по х = {x1}");
            else
                if (x3 == x1)
                Console.WriteLine($"Четвертая точка по х = {x2}");
            else
                Console.WriteLine($"Четвертая точка по х = {x3}");

            if (y2 == y3)
                Console.WriteLine($"Четвертая точка по у = {y1}");
            else
                if (y3 == y1)
                Console.WriteLine($"Четвертая точка по у = {y2}");
            else
                Console.WriteLine($"Четвертая точка по у = {y3}");
        }

        /// <summary>
        /// Для данного вещественного x найти значение следующей функции f,принимающей вещественные значения:
        ///         −x, если x ≤ 0,
        /// f(x) =  x(квадрат), если 0 < x < 2,
        ///         4, если x ≥ 2.         
        /// </summary>
        public static void If26()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Для данного вещественного x найти значение следующей функции f,принимающей вещественные значения:\n" +
                $"        −x, если x ≤ 0,\n" +
                $"f(x) =  x(квадрат), если 0 < x < 2,\n" +
                $"        4, если x ≥ 2. \n");
            Console.ResetColor();

            Console.WriteLine("Введите точку x, дробную часть указать через запятую");
            float x = Function.EnterTheNumber(float.MinValue, float.MaxValue);

            if (x <= 0)
                Console.WriteLine($"F(x) = {x * -1}");
            else if (0 < x && x < 2)
                Console.WriteLine($"F(x) = {x * x}");
            else if (x >= 2)
                Console.WriteLine($"F(x) = {4}");
        }
    }
}
