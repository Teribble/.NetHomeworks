using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public abstract class Ration
    {
        /// <summary>
        /// Наименование рациона
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Сумма каллорий в рационе
        /// </summary>
        public int Calories { get; set; }
        /// <summary>
        /// Цена за рацион
        /// </summary>
        public decimal Price { get; set; }

        private List<Food> _listOfFood;
        public Ration(string name)
        {
            Name = name;
        }

        public virtual void CalculateAmount()
        {

        }
    }
}
