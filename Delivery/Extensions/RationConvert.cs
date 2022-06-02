using Delivery.Collectors;
using Delivery.Foods;
using Delivery.Rations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Delivery.Extensions
{
    /// <summary>
    /// Класс расширение для класса JsonConverter, сделан для правильной серилизации и десирилизации интерфейса iRation
    /// </summary>
    public class RationConvert : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IRation);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);
            if (obj["Type"]!.Value<string>() == "0")
                return obj.ToObject<Balance>(serializer);
            if (obj["Type"]!.Value<string>() == "1")
                return obj.ToObject<Default>(serializer);
            if (obj["Type"]!.Value<string>() == "2")
                return obj.ToObject<Sport>(serializer);
            if (obj["Type"]!.Value<string>() == "3")
                return obj.ToObject<Vegan>(serializer);
            if (obj["Type"]!.Value<string>() == "4")
                return obj.ToObject<Premium>(serializer);
            
            return null;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
