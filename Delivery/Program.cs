using Delivery.Foods;
using Delivery.Rations;
using Delivery.Extensions;
using Newtonsoft.Json;
using Delivery.Collectors;
using Spectre.Console;

namespace Delivery
{
    public class Program
    {
        public static void Main()
        {

            Client client = new Client("Иванов Иван Иванович");

            Manager manager = new Manager();

            manager.CollectOrder(client.MakeOrder());

            if(manager.CheckList != null)
            {
                foreach (var check in manager.CheckList)
                {
                    Console.WriteLine("В заказ входят такие позиции как: \n");
                    foreach (var food in manager.GetRation().FoodList!)
                    {
                        Console.WriteLine(food);
                    }
                    Console.WriteLine("\n");
                    Thread.Sleep(1000);
                    check.Print();
                }
            }
        }
    }
}
