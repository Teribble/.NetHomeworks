using Delivery.Extensions;
using Delivery.Foods;
using Delivery.Rations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Delivery.Collectors
{
    public abstract class CollectorBuilder
    {
        protected abstract string Path { get; set; }

        protected IRation? Ration { get; set; }
        public void Reset()
        {
            Ration = null!;
        }
        public void CollectRation()
        {
            string json = File.ReadAllText(Path);

            JsonConverter[] converters = { new FoodConvert(), new RationConvert() };

            Ration = JsonConvert.DeserializeObject<IRation>(json, new JsonSerializerSettings() { Converters = converters });
        }

        public IRation GetRation()
        {
            return Ration!;
        }
    }
}
