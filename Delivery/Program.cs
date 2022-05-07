using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Program
    {
        public static void Main()
        {
            Food[] food = { new Drink("Пиво", 12), new Dish("Мясо", 800) };
            foreach (var f in food)
            {
                Console.WriteLine(f.Name + " " + f.Calories);
            }
        }
    }
}
