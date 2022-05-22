using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Drink : Food
    {
        public override FoodType Type { get; set; }
        public override string Name { get; set; }
        public override float Calories { get; set; }
        public override decimal Price { get; set; }
    }
}
