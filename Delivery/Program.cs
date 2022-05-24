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
            //IRation rat = new Balance();
            //rat.FoodList!.Add(new Dish("Meat", 123, 123));
            //rat.FoodList.Add(new Drink("Cola", 444, 444));
            //rat.FoodList.Add(new Drink("Cola", 444, 444));
            //rat.FoodList.Add(new Drink("Cola", 444, 444));
            //
            //string json1 = JsonConvert.SerializeObject(rat, Formatting.Indented);
            //string path = "Rations/JSON/Vegan.json";
            //File.WriteAllText(path, json1);

            //string json = File.ReadAllText(path);
            //
            //JsonConverter[] converters = { new FoodConvert(), new RationConvert() };
            //var test = JsonConvert.DeserializeObject<IRation>(json, new JsonSerializerSettings() { Converters = converters });
            //
            //Console.WriteLine("Type ration: " + test!.Type);

            CollectorBuilder b = new VeganCollector();

            b.CollectRation();
            var test = b.GetRation();

            Console.WriteLine("Type collector: " + test.Type);
            foreach (var food in test!.FoodList!)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine(String.Format("Калории: {0:00.0} калл", test.Calories));
            Console.WriteLine(String.Format("Цена рациона: {0:00.0} руб", test.Price));
        }
    }
}
