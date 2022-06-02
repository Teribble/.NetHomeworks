using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Foods
{
    /// <summary>
    /// Блюдо
    /// </summary>
    public class Dish : IFood
    {
        /// <summary>
        /// Тип еды
        /// </summary>
        public FoodType Type { get; }
        /// <summary>
        /// Наименование еды
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Калории
        /// </summary>
        public float Calories { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Блюдо
        /// </summary>
        /// <param name="name">Наименование блюда</param>
        /// <param name="calories">Кол-во калорий в блюде</param>
        /// <param name="price">Цена блюда</param>
        /// <exception cref="ArgumentException"></exception>
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
