using System;
using System.Threading;

namespace itsTime
{
    public class iTimer
    {
        private const int _Second = 1000;

        private int _hour;

        private byte _minute;

        private byte _second;

        private bool _isStopped;

        public iTimer()
        {
            _isStopped = true;
        }

        public void Start()
        {
            DisplayRules();
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    if (_isStopped && _second == 0)
                        Start(_hour, _minute, _second);
                    else
                        Stop();
                    break;
                case ConsoleKey.D2:
                    Continue();
                    break;
            }
            Start();
        }

        public void Stop()
        {
            if (_isStopped)
                Reset();
            else
                _isStopped = true;
            PrintTime();
        }

        public void Continue()
        {
            if(_isStopped && (_second + _minute + _hour) > 0)
                Start(_hour, _minute, _second);
        }

        public void Reset()
        {
            _hour = _minute = _second = 0;
            PrintTime();
        }

        private void IncrementSecond()
        {
            if (!_isStopped)
            {
                Thread.Sleep(_Second);
                if (_second < 59)
                    _second++;
                else
                {
                    IncrementMinute();
                    _second = 0;
                }
            }
        }

        private void IncrementMinute()
        {
            if (_minute < 59)
                _minute++;
            else
            {
                _hour++;
                _minute = 0;
            }
        }

        private void PrintTime()
        {
            Console.SetCursorPosition(7, 3);
            Console.Write(_hour.ToString("00") + ":" + _minute.ToString("00") + ":" + _second.ToString("00"));
        }

        public void Start(int hour, int minute, int second)
        {
            _isStopped = false;
            new Thread(StartTimer).Start();
        }

        private void StartTimer()
        {
            while (!_isStopped)
            {
                PrintTime();
                IncrementSecond();
            }
        }

        private void DisplayRules()
        {
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Для сброса таймера:\n нажмите два раза Stop");
            Console.SetCursorPosition(0, 5);
            if (_isStopped && _second == 0)
                Console.Write("1: Start\n2: Continue");
            else
                Console.Write("1: Stop \n2: Continue");
        }

    }
}
