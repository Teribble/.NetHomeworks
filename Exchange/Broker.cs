using System;
using System.Threading;

namespace Exchange
{
    /// <summary>
    /// Брокер
    /// </summary>
    public class Broker
    {
        private static int _counterId = 0;
        public int Id { get; }

        private const int MaxFunds = 15000;
        /// <summary>
        /// Доступный депозит
        /// </summary>
        public decimal AvailableFunds { get; private set; }
        public Broker()
        {
            Id = ++_counterId;
            AvailableFunds = new Random().Next(MaxFunds);
        }
        /// <summary>
        /// Купить акцию
        /// </summary>
        /// <param name="price">Цена акции</param>
        public void BuyAsset(decimal price)
        {
            Thread.Sleep(new Random().Next(3000));
            if(price >= AvailableFunds)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Брокер {Id} воздержался от покупки");
                Console.ResetColor();
            }
                
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Брокер {Id} купил актив");
                Console.ResetColor();
            }
               
        }
    }
}