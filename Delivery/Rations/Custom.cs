using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Foods;

namespace Delivery.Rations
{
    public class Custom : IRation
    {
        private float _calories;
        private decimal _price;
        public RationType Type { get; }
        public List<IFood>? FoodList { get; set; }
        public float Calories
        {
            get
            {
                _calories = FoodList!.Sum(food => food.Calories);
                return _calories;
            }
            set
            {
                _calories = value;
            }
        }
        public decimal Price
        {
            get
            {
                _price = FoodList!.Sum(food => food.Price);
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public Custom()
        {
            Type = RationType.Balance;
            FoodList = new List<IFood>();
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
