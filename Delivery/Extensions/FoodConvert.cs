using Delivery.Foods;
using Delivery.Rations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Delivery.Extensions
{
    public class FoodConvert : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IFood);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);
            if (obj["Type"]!.Value<string>() == "0")
                return obj.ToObject<Dish>(serializer);

            if (obj["Type"]!.Value<string>() == "1")
                return obj.ToObject<Drink>(serializer);

            return null;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
