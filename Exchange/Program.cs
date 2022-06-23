using System;
using System.Collections.Generic;
using System.Threading;

namespace Exchange
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Bank> banks = new List<Bank>();
            banks.Add(new Bank());
            banks.Add(new Bank());
            banks.Add(new Bank());
            banks.Add(new Bank());
            banks.Add(new Bank());
            banks.Add(new Bank());
            banks.Add(new Bank());
            banks.Add(new Bank());
            banks.Add(new Bank());
            
            List<Broker> brokers = new List<Broker>();
            brokers.Add(new Broker());
            brokers.Add(new Broker());
            brokers.Add(new Broker());
            brokers.Add(new Broker());
            brokers.Add(new Broker());
            
            Exchange exchange = new Exchange(banks, brokers);
            
            exchange.Start();

            




        }
    }
}
