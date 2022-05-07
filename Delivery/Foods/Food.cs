using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public abstract class Food
    {
        public string? Name { get; set; }

        public int Calories { get; set; }

        public decimal Price { get; set; }

    }
}
