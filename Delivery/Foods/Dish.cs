using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Dish : Food
    {
        public Dish(string name, int calories, decimal price)
        {
            Name = name;

            Calories = calories;

            Price = price;
        }
    }
}
