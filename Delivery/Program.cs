using Delivery.Rations;
using Delivery.Extensions;
using Newtonsoft.Json;

namespace Delivery
{
    public class Program
    {
        public static void Main()
        {
            //IRation rat = new Balance();
            //rat.FoodList.Add(new Dish("Meat", 123, 123));
            //rat.FoodList.Add(new Drink("Cola", 444, 444));
            //string json1 = JsonConvert.SerializeObject(rat, Formatting.Indented);
            //File.WriteAllText("rat.json", json1);
            //Console.WriteLine(json1);

            string json = File.ReadAllText("rat.json");
            //Console.WriteLine(json);
            JsonConverter[] converters = { new FoodConvert(), new RationConvert() };
            var test = JsonConvert.DeserializeObject<IRation>(json, new JsonSerializerSettings() { Converters = converters });

            foreach (var food in test!.FoodList!)
            {
                Console.WriteLine(food);
            }
        }
    }
}
