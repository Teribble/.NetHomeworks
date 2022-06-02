using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Foods
{
    /// <summary>
    /// Напиток
    /// </summary>
    public class Drink : IFood
    {
        /// <summary>
        /// Тип продукта
        /// </summary>
        public FoodType Type { get; }
        /// <summary>
        /// Наименование напитка
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
        /// Напиток
        /// </summary>
        /// <param name="name">Наименование напитка</param>
        /// <param name="calories">Кол-во калорий</param>
        /// <param name="price">Цена напитка</param>
        /// <exception cref="ArgumentException"></exception>
        public Drink(string name, float calories, decimal price)
        {
            Type = FoodType.Drink;

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
