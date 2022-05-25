using Delivery.Rations;
using Spectre.Console;

namespace Delivery
{
    public class Check
    {
        private int _discount;
        public RationType Type { get; }
        public int CountDay { get; }
        public float Calories { get; }
        public decimal Price { get; }
        public DateTime Date { get; }
        public int Discount { get; set; }
        public decimal PriceDiscount { get; }

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