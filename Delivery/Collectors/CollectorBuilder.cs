using Delivery.Extensions;
using Delivery.Foods;
using Delivery.Rations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Delivery.Collectors
{
    /// <summary>
    /// Абстрактный класс "Сборщик"
    /// </summary>
    public abstract class CollectorBuilder
    {
        /// <summary>
        /// Путь
        /// </summary>
        protected abstract string Path { get; set; }
        /// <summary>
        /// Рацион
        /// </summary>
        protected IRation? Ration { get; set; }
        public void Reset()
        {
            Ration = null!;
        }
        /// <summary>
        /// Собрать рацион
        /// </summary>
        public void CollectRation()
        {
            string json = File.ReadAllText(Path);

            JsonConverter[] converters = { new FoodConvert(), new RationConvert() };

            Ration = JsonConvert.DeserializeObject<IRation>(json, new JsonSerializerSettings() { Converters = converters });
        }
        /// <summary>
        /// Выдать рацион
        /// </summary>
        /// <returns>Возвращает собранный рацион</returns>
        public IRation GetRation()
        {
            return Ration!;
        }
    }
}
