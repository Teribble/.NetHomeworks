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
            //Order order = new Order { Type = RationType.Default, CountDay = 11};
            //Order order1 = new Order { Type = RationType.Sport, CountDay = 20 };
            //Order order2 = new Order { Type = RationType.Vegan, CountDay = 31 };
            //Order order3 = new Order { Type = RationType.Premium, CountDay = 2 };
            //
            //Manager manager = new Manager();
            //manager.CollectOrder(order);
            //manager.CollectOrder(order1);
            //manager.CollectOrder(order2);
            //manager.CollectOrder(order3);
            //
            //foreach (var check in manager.CheckList!)
            //{
            //    Thread.Sleep(1000);
            //    check.Print();
            //}

            var image = new CanvasImage("../../../PNG/png.jpg");

            // Set the max width of the image.
            // If no max width is set, the image will take
            // up as much space as there is available.
            image.MaxWidth(128);

            // Render the image to the console
            Console.ReadLine();
            AnsiConsole.Write(image);
        }
    }
}
