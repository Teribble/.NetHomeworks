using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Drink : Food
    {
        public Drink(string name, int calories, decimal price)
        {
            Name = name;

            Calories = calories;

            Price = price;
        }
    }
}
