using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    /// <summary>
    /// Класс собственных функций
    /// </summary>
    public static class MyFunction
    {
        /// <summary>
        /// Функция ввода числа в заданом диапазоне с проверкой введеного значения
        /// </summary>
        /// <param name="min">Диапазон от, если не указан будет 0</param>
        /// <param name="max">Диапазон до, если не указан то будет maxValue</param>
        /// <returns>Вернет интовое значение</returns>
        public static int EnterTheNumber(int min = 0, int max = int.MaxValue)
        {

            int value;

            Console.WriteLine($"Допустимое число от {min} до {max}");

            do
            {

                while (!int.TryParse(Console.ReadLine(), out value)) { }

            } while (value > max || value < min);

            return value;
        }

        public static float EnterTheNumber(float min = 0f, float max = float.MaxValue)
        {

            float value;

            Console.WriteLine($"Допустимое число от {min} до {max}");

            do
            {

                while (!float.TryParse(Console.ReadLine(), out value)) { }

            } while (value > max || value < min);

            return value;
        }
    }
}
