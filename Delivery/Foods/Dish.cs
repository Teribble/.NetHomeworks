using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Foods
{
    public class Dish : IFood
    {
        public FoodType Type { get; }
        public string? Name { get; set; }
        public float Calories { get; set; }
        public decimal Price { get; set; }

        public Dish(string name, float calories, decimal price)
        {
            Type = FoodType.Dish;

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Error");
            Name = name;

            if (calories < 0)
                throw new ArgumentException("Error");
            Calories = calories;

            if (price < 0)
                throw new ArgumentException("Error");
            Price = price;
        }

        public override string ToString()
        {
            string calories = string.Format("\nCalories: {00:0.0} калл", Calories);
            string name = string.Format("\nНаименование: {0}", Name);
            string type = string.Format("Тип продукта: {0}", Type);
            return type + name + calories;
        }
    }
}
