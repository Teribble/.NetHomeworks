using System;
using System.Threading;

namespace itsTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Timer";

#pragma warning disable CA1416 // Проверка совместимости платформы
            Console.SetWindowSize(22, 8);
#pragma warning restore CA1416 // Проверка совместимости платформы

#pragma warning disable CA1416 // Проверка совместимости платформы
            Console.SetBufferSize(22, 8);
#pragma warning restore CA1416 // Проверка совместимости платформы

            Console.CursorVisible = false;

            var timer = new Timer();

            timer.Start();
        }
    }
}
