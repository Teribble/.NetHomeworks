using System;
using System.Threading;

namespace Exchange
{
    /// <summary>
    /// Банк
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// Максимальная стоимость актива, сделана для рандомайзера
        /// </summary>
        public const int MaxPrice = 15000;
        /// <summary>
        /// Предложить акцию, по рандомной цене
        /// </summary>
        /// <returns></returns>
        public decimal OfferAnAsset()
        {
            Thread.Sleep(new Random().Next(3000));

            decimal price = new Random().Next(MaxPrice);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Поступило новое предложение от банка, стоимость актива = " + price);
            Console.ResetColor();

            return price;
        }
    }
}