using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Foods
{
    /// <summary>
    /// Интерфейс для продуктов
    /// </summary>
    public interface IFood
    {
        /// <summary>
        /// Тип продукта
        /// </summary>
        public FoodType Type { get; }
        /// <summary>
        /// Наименование продукта
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Калории продукта
        /// </summary>
        public float Calories { get; set; }
        /// <summary>
        /// Цена продутка
        /// </summary>
        public decimal Price { get; set; }
    }
}
