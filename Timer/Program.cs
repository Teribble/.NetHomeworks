using System;

namespace itsTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Timer";
            Console.SetWindowSize(22, 8);
            Console.SetBufferSize(22, 8);

            Console.CursorVisible = false;

            var timer = new iTimer();

            timer.Start();
        }
    }
}
