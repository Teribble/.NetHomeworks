using Delivery.Foods;

namespace Delivery.Rations
{
    public class Balance : IRation
    {
        public RationType Type { get; }
        public List<IFood>? FoodList { get; set; }
        public float Calories { get; set; }
        public decimal Price { get; set; }

        public Balance()
        {
            Type = RationType.Balance;
            FoodList = new List<IFood>();
            Calories = FoodList.Sum(food => food.Calories);
            Price = FoodList.Sum(food => food.Price);
        }
        public override string ToString()
        {
            string type = "Type: " + Type;
            string foodlist = FoodList!.ToArray().ToString()!;
            string price = string.Format("\nPrice: {00:0.00}р", Price);
            string calories = string.Format("\nCalories: {00:0.00} калл", Calories);

            return type + foodlist + price + calories;
        }
    }
}
