using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exchange
{
    /// <summary>
    /// Биржа
    /// </summary>
    public class Exchange
    {
        public delegate void ChangePrice(decimal price);

        public event ChangePrice ChangePriceHandler;
        /// <summary>
        /// Список банков
        /// </summary>
        List<Bank> Banks { get; set; }
        /// <summary>
        /// Список брокеров
        /// </summary>
        List<Broker> Brokers { get; set; }
        /// <summary>
        /// Старт торгов
        /// </summary>
        public void Start()
        {
            ConsoleKey key = ConsoleKey.Enter;

            AlertBroker();

            if (Banks != null)
            {
                foreach (var bank in Banks)
                {
                    if (!Console.KeyAvailable == true)
                    {
                        Console.WriteLine("Enter - начать торги , Esc - Выход");

                        key = Console.ReadKey(true).Key;
                    }

                    if (key == ConsoleKey.Enter)
                        ChangePriceHandler.Invoke(bank.OfferAnAsset());
                    else
                        break;
                }
            }
            
        }
        /// <summary>
        /// Оповестить брокеров
        /// </summary>
        private void AlertBroker()
        {
            if (Brokers != null)
                foreach (var broker in Brokers)
                {
                    ChangePriceHandler += broker.BuyAsset;
                }
        }
        /// <summary>
        /// Биржа
        /// </summary>
        /// <param name="banks">Список банков</param>
        /// <param name="brokers">Список брокеров</param>
        public Exchange(List<Bank> banks, List<Broker> brokers)
        {
            Banks = banks;

            Brokers = brokers;
        }
    }
}
