using Delivery.Foods;

namespace Delivery.Rations
{
    public class Default : IRation
    {
        public RationType Type { get; }
        public List<IFood>? FoodList { get; set; }
        public float Calories { get; set; }
        public decimal Price { get; set; }

        public Default()
        {
            Type = RationType.Default;
            FoodList = new List<IFood>();
            Calories = FoodList.Sum(food => food.Calories);
            Price = FoodList.Sum(food => food.Price);
        }
    }
}
