using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Terrible
{
    public static class Tasks
    {
        /// <summary>
        /// Впомогательная функция для Case10
        /// </summary>
        /// <param name="direction">Направление</param>
        /// <param name="action">Действие</param>
        /// <returns></returns>
        private static string Case10_1(string direction, int action)
        {
            switch (direction)
            {
                case "С":
                    switch (action)
                    {
                        case -1:
                            return "Восток";
                        case 0:
                            return "Cевер";
                        case 1:
                            return "Запад";
                    }
                    break;
                case "З":
                    switch (action)
                    {
                        case -1:
                            return "Север";
                        case 0:
                            return "Запад";
                        case 1:
                            return "Юг";
                    }
                    break;
                case "Ю":
                    switch (action)
                    {
                        case -1:
                            return "Запад";
                        case 0:
                            return "Юг";
                        case 1:
                            return "Восток";
                    }
                    break;
                case "В":
                    switch (action)
                    {
                        case -1:
                            return "Юг";
                        case 0:
                            return "Восток";
                        case 1:
                            return "Север";
                    }
                    break;
            }
            return "hehe";
        }
        /// <summary>
        /// Робот может перемещаться в четырех направлениях («С» — север, «З» — запад, «Ю» — юг, «В» — восток) 
        /// и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, −1 — поворотнаправо. 
        /// Дан символ C — исходное направление робота и целое число N— посланная ему команда. 
        /// Вывести направление робота после выполнения полученной команды.
        /// </summary>
        public static void Case10()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Робот может перемещаться в четырех направлениях («С» — север, «З» — запад, «Ю» — юг, «В» — восток) \n" +
                              $"и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, −1 — поворотнаправо. \n" +
                              $"Дан символ C — исходное направление робота и целое число N— посланная ему команда. \n" +
                              $"Вывести направление робота после выполнения полученной команды.\n");
            Console.ResetColor();

            string direction = null;
            do
            {
                Console.WriteLine("Введите начальное направление: «С» — север, «З» — запад, «Ю» — юг, «В» — восток");
                direction = Console.ReadLine();
            } while (!(direction == "С" || direction == "З" || direction == "Ю" || direction == "В"));

            Console.WriteLine("Выберте действие: (0) — продолжать движение, (1) — поворот налево, (-1) — поворот направо");
            int action = iHelper.Function.EnterTheNumber(-1, 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Направление: {Case10_1(direction, action)}");
            Console.ResetColor();

            Console.WriteLine("Для продолжения нажмите ENTER");
            Console.ReadLine();
        }
        /// <summary>
        /// Впомогательная функция для Case15
        /// Возращает название карты по порядковому номеру
        /// </summary>
        /// <param name="dignity">порядковый номер</param>
        /// <returns></returns>
        private static string Case15_02(int dignity)
        {
            switch (dignity)
            {
                case 1:
                    return "пика";
                case 2:
                    return "трефа";
                case 3:
                    return "бубна";
                case 4:
                    return "черва";
            }
            return "hehe";
        }
        /// <summary>
        /// Впомогательная функция для Case15
        /// Возращает полное название карты, по порядковому номера и достоинству
        /// </summary>
        /// <param name="serialNumber">Порядковый номер</param>
        /// <param name="dignity">Достоинство</param>
        /// <returns></returns>
        private static string Case15_01(int serialNumber, int dignity)
        {
            switch (serialNumber)
            {
                case 6:
                    return $"Шестерка-{Case15_02(dignity)}";
                case 7:
                    return $"Семерка-{Case15_02(dignity)}";
                case 8:
                    return $"Восьмёрка-{Case15_02(dignity)}";
                case 9:
                    return $"Девятка-{Case15_02(dignity)}";
                case 10:
                    return $"Десятка-{Case15_02(dignity)}";
                case 11:
                    return $"Валет-{Case15_02(dignity)}";
                case 12:
                    return $"Дама-{Case15_02(dignity)}";
                case 13:
                    return $"Король-{Case15_02(dignity)}";
                case 14:
                    return $"Туз-{Case15_02(dignity)}";
            }
            return "hehe";
        }
        /// <summary>
        /// Мастям игральных карт присвоены порядковые номера: 1 — пики,2 — трефы, 3 — бубны, 4 — червы.
        /// Достоинству карт, старших десятки,присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз.
        /// Даны два целых числа: N — достоинство(6 ≤ N ≤ 14) и M — масть карты (1 ≤ M ≤ 4). 
        /// Вывести название соответствующей карты вида «шестерка-бубен», «дама червей», «туз треф» и т.п.
        /// </summary>
        public static void Case15()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Мастям игральных карт присвоены порядковые номера: 1 — пики,2 — трефы, 3 — бубны, 4 — червы.\n" +
                              $"Достоинству карт, старших десятки,присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз.\n" +
                              $"Даны два целых числа: N — достоинство(6 ≤ N ≤ 14) и M — масть карты (1 ≤ M ≤ 4).\n" +
                              $"Вывести название соответствующей карты вида «шестерка-бубен», «дама червей», «туз треф» и т.п.\n");
            Console.ResetColor();

            Console.WriteLine("Введите порядковый номер карты: ");
            int serialNumber = iHelper.Function.EnterTheNumber(6, 14);

            Console.WriteLine("Введите достоинство карты: ");
            int dignity = iHelper.Function.EnterTheNumber(1, 4);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Case15_01(serialNumber, dignity));
            Console.ResetColor();

            Console.WriteLine("Для продолжения нажмите ENTER");
            Console.ReadLine();
        }
        /// <summary>
        /// Дано вещественное число A и целое число N (> 0). Используя одинцикл,
        /// найти сумму 1 + A + A^2 + A^3 + . . . + A^N.
        /// </summary>
        public static void For17()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Дано вещественное число A и целое число N (> 0). " +
                              $"\nИспользуя один цикл, найти сумму1 + A + A ^ 2 + A ^ 3 + … +A ^ N\n");
            Console.ResetColor();

            Console.WriteLine("Введите целое число N: ");
            int N = iHelper.Function.EnterTheNumber(0, int.MaxValue);

            Console.WriteLine("Введите вещественное число А: ");
            float A = iHelper.Function.EnterTheNumber(1, float.MaxValue);

            float aBuffer = 1, result = 1;
            for (int i = 1; i <= N; i++)
            {
                aBuffer *= A;
                result += aBuffer;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: {result}");
            Console.ResetColor();

            Console.WriteLine("Для продолжения нажмите ENTER");
            Console.ReadLine();
        }
        /// <summary>
        /// Дано целое число N (> 0). Найти сумму 1N + 2N−1 + . . . + N1.
        /// Чтобы избежать целочисленного переполнения, вычислять слагаемые
        /// этой суммы с помощью вещественной переменной и выводить результат как вещественное число.
        /// </summary>
        public static void For38()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Дано целое число N (> 0). Найти сумму 1^N + 2^N−1 + . . . + N^1.\n" +
                              $"Чтобы избежать целочисленного переполнения, вычислять слагаемые\n" +
                              $"этой суммы с помощью вещественной переменной и выводить результат как вещественное число.\n");
            Console.ResetColor();

            Console.WriteLine("Введите целое число N: ");
            int N = iHelper.Function.EnterTheNumber(1,int.MaxValue);

            double result = 0D, nI;

            for (int i = 0; i < N; i++)
            {
                nI = i;
                for (int j = 0; j < N - i; j++)
                {
                    nI *= i;
                    result += nI;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: {result}");
            Console.ResetColor();

            Console.WriteLine("Для продолжения нажмите ENTER");
            Console.ReadLine();
        }
        /// <summary>
        /// Дано целое число N (> 1), являющееся числом Фибоначчи: N = F^K
        /// (определение чисел Фибоначчи дано в задании While24).
        /// Найти целые числа F^K−1 и F^K+1 — предыдущее и последующее числа Фибоначчи.
        /// </summary>
        public static void While26()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Дано целое число N (> 1), являющееся числом Фибоначчи: N = F^K\n" +
                              $"(определение чисел Фибоначчи дано в задании While24).\n" +
                              $"Найти целые числа F^K−1 и F^K+1 — предыдущее и последующее числа Фибоначчи.\n");
            Console.ResetColor();

            Console.WriteLine("Введите целое число: ");
            int N = iHelper.Function.EnterTheNumber(1, int.MaxValue);

            Console.WriteLine("Введите вещественное число N2");
            float N2 = iHelper.Function.EnterTheNumber(1f, float.MaxValue);

            float N1 = N2, result = N2;

            for (int i = 2, k = 1; i <= N; i++)
            {
                k += 2;
                N1 *= -1 * N2 * N2;
                result += N1 / k;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: {result}");
            Console.ResetColor();

            Console.WriteLine("Для продолжения нажмите ENTER");
            Console.ReadLine();
        }
        /// <summary>
        ///  Дано вещественное число ε (> 0). Последовательность вещественных чисел A^K определяется следующим образом:
        ///  A1 = 2,
        ///  AK = 2 + 1/A^K−1,
        ///  K = 2, 3, . . . .
        ///  Найти первый из номеров K, для которых выполняется условие|A^K − A^K−1| < ε, и вывести этот номер, а также числа A^K−1 и AK.
        /// </summary>
        public static void While28()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Дано вещественное число ε (> 0). Последовательность вещественных чисел A^K определяется следующим образом:\n" +
                              $"A1 = 2,\nAK = 2 + 1/A^K−1,\nK = 2, 3, . . . .\n" +
                              $"Найти первый из номеров K, для которых выполняется условие|A^K − A^K−1| < ε,\n" +
                              $"и вывести этот номер, а также числа A^K−1 и AK.\n");
            Console.ResetColor();

            Console.WriteLine("Введите вещественное число ε");
            float X = iHelper.Function.EnterTheNumber(1, float.MaxValue);

            Console.WriteLine("Введите целое число N: ");
            int N = iHelper.Function.EnterTheNumber(1, int.MaxValue);

            float temp1 = 1, temp2 = 1, result = 1, pow = 1;

            for (int i = 1; i < N; i++)
            {
                temp1 *= 2 * i - 3;
                temp2 *= 2 * i;
                pow *= (-1) * X;
                result += temp1 * pow / temp2;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: {result}");
            Console.ResetColor();

            Console.ReadLine()
;        }
        /// <summary>
        /// Дано целое число N (> 1) и набор из N чисел. Найти номера
        /// двух соседних чисел из данного набора, произведение которых является
        /// минимальным, и вывести вначале меньший, а затем больший номер
        /// </summary>
        public static void Minmax25()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Дано целое число N (> 1) и набор из N чисел. \n" +
                              $"Найти номера двух соседних чисел из данного набора, произведение которых является\n" +
                              $"минимальным, и вывести вначале меньший, а затем больший номер\n");
            Console.ResetColor();

            int N, i, imul = 0;
            float r1 = 0, r2 = 0, minmul = 0;

            Console.WriteLine("Введите целое число N: ");
            N = iHelper.Function.EnterTheNumber(1, int.MaxValue);

            for (i = 1; i <= N; ++i)
            {
                r2 = r1;
                Console.WriteLine($"i > {i}");
                r1 = iHelper.Function.EnterTheNumber(0f, float.MaxValue);

                if ((i == 2) || (r1 * r2 < minmul))
                {
                    minmul = r2 * r1;
                    imul = i;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Min1: {imul - 1}\nMin2: {imul}");
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
