using Delivery.Rations;
using Spectre.Console;

namespace Delivery
{
    /// <summary>
    /// Чек
    /// </summary>
    public class Check
    {
        /// <summary>
        /// Скидка
        /// </summary>
        private int _discount;
        /// <summary>
        /// Тип рациона
        /// </summary>
        public RationType Type { get; }
        /// <summary>
        /// Количество дней доставки
        /// </summary>
        public int CountDay { get; }
        /// <summary>
        /// Калории
        /// </summary>
        public float Calories { get; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; }
        /// <summary>
        /// Дата печати чека
        /// </summary>
        public DateTime Date { get; }
        /// <summary>
        /// Скидка
        /// </summary>
        public int Discount { get; set; }
        /// <summary>
        /// Скидка в рублях
        /// </summary>
        public decimal PriceDiscount { get; }
        /// <summary>
        /// Чек
        /// </summary>
        /// <param name="ration">Тип рациона</param>
        /// <param name="order">заказ</param>
        public Check(IRation ration, Order order)
        {
            Type = order.Type;

            CountDay = order.CountDay;

            if (CountDay <= 10)
                _discount = 5;
            else if (CountDay > 10 && CountDay <=20)
                _discount = 7;
            else if (CountDay > 20 && CountDay <= 30 || CountDay > 30)
                _discount = 9;
            else _discount = 0;

            Calories = ration.Calories;

            PriceDiscount = (ration.Price / 100) * _discount;

            if (_discount == 0)
                Price = ration.Price;
            else
                Price = ration.Price - PriceDiscount;

            Date = DateTime.Now;
        }
        /// <summary>
        /// Печать чека
        /// </summary>
        public void Print()
        {
            var table = new Table();
            table.Border = TableBorder.HeavyHead;

            var panel = new Panel
                ("_________________________"
                + "\nType: " + Type
                + "\nDiscount percent: " + _discount + "%"
                + "\nCalories: " + Calories + " калл"
                + "\nDiscount: " + PriceDiscount + "р"
                + "\nPrice: " + Price + "р"
                + "\nDate: " + Date
                + "\nDay delivery: " + CountDay + "d"
                + "\n_________________________"
                );
            panel.Border = BoxBorder.Heavy;

            table.AddColumn("Delivery by Teribble");
            table.AddRow(panel);
            table.AddRow(new Panel
                ( "Total price: " + Price * CountDay
                + "\nPrice without VAT: " + Price * CountDay
                + "\n_________________________"
                )) ;
            

            AnsiConsole.Write(table);
            
        }
    }
}