using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Dish : Food
    {
        public override FoodType Type { get;}
        public override string Name { get; set; }
        public override float Calories { get; set; }
        public override decimal Price { get; set; }
        public Dish(string name, float calories, decimal price)
        {
            Type = FoodType.Dish;
            Name = name;
            Calories = calories;
            Price = price;
        }
    }
}
