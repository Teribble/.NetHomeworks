using Delivery.Foods;

namespace Delivery.Rations
{
    /// <summary>
    /// Интерфейс для рационов
    /// </summary>
    public interface IRation
    {
        public RationType Type { get; }
        public List<IFood>? FoodList { get; set; }
        public float Calories { get; set; }
        public decimal Price { get; set; }
    }
}
