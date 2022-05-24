using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Foods
{
    public interface IFood
    {
        public FoodType Type { get; }
        public string? Name { get; set; }
        public float Calories { get; set; }
        public decimal Price { get; set; }
    }
}
