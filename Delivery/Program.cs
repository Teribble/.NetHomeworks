using Delivery.Foods;
using Delivery.Rations;
using Delivery.Extensions;
using Newtonsoft.Json;
using Delivery.Collectors;

namespace Delivery
{
    public class Program
    {
        public static void Main()
        {
            Order order = new Order { Type = RationType.Default, CountDay = 11};
            Order order1 = new Order { Type = RationType.Sport, CountDay = 21 };
            Order order2 = new Order { Type = RationType.Vegan, CountDay = 31 };
            Order order3 = new Order { Type = RationType.Premium, CountDay = 0 };
            
            Manager manager = new Manager();
            manager.CollectOrder(order);
            manager.CollectOrder(order1);
            manager.CollectOrder(order2);
            manager.CollectOrder(order3);

            foreach (var check in manager.CheckList!)
            {
                Thread.Sleep(1000);
                check.Print();
            }


        }
    }
}
